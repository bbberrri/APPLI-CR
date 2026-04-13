using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLI_CR
{
    public partial class FrmGestionVisiteurs : Form
    {
        //private TextBox txtCp;

        public FrmGestionVisiteurs()
        {
            InitializeComponent();
            //this.BindDataGridView();
            //txtCp = new TextBox
            //{
            //    Name = "txtCp",
            //    Location = new Point(150, 150),
            //    Size = new Size(200, 20)
            //};

            //this.Controls.Add(txtCp);
        }

        // Inutile
        private void BindDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[9] {new DataColumn("id", typeof(string)),
                                                new DataColumn("nom", typeof(string)),
                                                new DataColumn("prenom", typeof(string)),
                                                new DataColumn("login", typeof(string)),
                                                new DataColumn("mdp", typeof(string)),
                                                new DataColumn("adresse", typeof(string)),
                                                new DataColumn("cp", typeof(string)),
                                                new DataColumn("ville", typeof(string)),
                                                new DataColumn("dateEmbauche", typeof(DateTime)) });
            dt.Rows.Add("abcde", "Berri", "Bilal", "bberri", "1234", "5 square de Blois",
                    "95380", "Louvres", new DateTime(2025, 03, 01));
            this.VisiteursDataGridView.DataSource = dt;
        }

        private void FrmGestionVisiteurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet.visiteur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.visiteurTableAdapter.Fill(this.gsbrapports2016DataSet.visiteur);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAddVisiteur_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=BB\BERRI;Initial Catalog=gsbrapports2016;Integrated Security=true";
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();
            string cp = txtCP.Text.Trim();
            string ville = txtVille.Text.Trim();
            DateTime dateEmbauche = dtpDateEmbauche.Value;

            // Générer le login : première lettre du prénom + nom, tout en minuscules
            string login = (prenom.Length > 0 ? prenom[0].ToString() : "") + nom;
            login = login.ToLower();

            // Générer un mot de passe aléatoire de 8 caractères
            string mdp = Guid.NewGuid().ToString("N").Substring(0, 8);

            // Générer un id unique (par exemple, un GUID tronqué à 3 caractères)
            string id = Guid.NewGuid().ToString("N").Substring(0, 3);

            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = @"INSERT INTO visiteur 
                (id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) 
                VALUES (@id, @nom, @prenom, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche);
                SELECT id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche FROM visiteur WHERE id = @id;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@mdp", mdp);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@cp", cp);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@dateEmbauche", dateEmbauche);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string info = $"ID : {reader["id"]}\n" +
                                          $"Nom : {reader["nom"]}\n" +
                                          $"Prénom : {reader["prenom"]}\n" +
                                          $"Login : {reader["login"]}\n" +
                                          $"Mot de passe : {reader["mdp"]}\n" +
                                          $"Adresse : {reader["adresse"]}\n" +
                                          $"CP : {reader["cp"]}\n" +
                                          $"Ville : {reader["ville"]}\n" +
                                          $"Date d'embauche : {Convert.ToDateTime(reader["dateEmbauche"]).ToShortDateString()}";
                            MessageBox.Show("Visiteur ajouté avec succès !\n\n" + info, "Ajout Visiteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    con.Close();
                }
            }

            // Rafraîchir la liste des visiteurs
            this.visiteurTableAdapter.Fill(this.gsbrapports2016DataSet.visiteur);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (VisiteursDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un visiteur à supprimer.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Utilisation de DataBoundItem pour plus de robustesse
            var rowView = VisiteursDataGridView.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null)
            {
                MessageBox.Show("Impossible de récupérer les données du visiteur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = rowView["id"].ToString();
            string constring = @"Data Source=BB\BERRI;Initial Catalog=gsbrapports2016;Integrated Security=true";

            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce visiteur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    string query = "DELETE FROM visiteur WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Visiteur supprimé avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun visiteur trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Rafraîchir la liste des visiteurs
                this.visiteurTableAdapter.Fill(this.gsbrapports2016DataSet.visiteur);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (VisiteursDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un visiteur à modifier.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowView = VisiteursDataGridView.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null)
            {
                MessageBox.Show("Impossible de récupérer les données du visiteur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pré-remplir les champs
            txtNom.Text = rowView["nom"].ToString();
            txtPrenom.Text = rowView["prenom"].ToString();
            txtAdresse.Text = rowView["adresse"].ToString();
            txtCP.Text = rowView["cp"].ToString();
            txtVille.Text = rowView["ville"].ToString();
            dtpDateEmbauche.Value = Convert.ToDateTime(rowView["dateEmbauche"]);

            // Stocker l'id dans le Tag du bouton pour la modification
            btnModifier.Tag = rowView["id"].ToString();
        }
    }
}
