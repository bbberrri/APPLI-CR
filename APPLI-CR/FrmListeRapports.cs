using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLI_CR
{
    public partial class FrmListeRapports : Form
    {
        private string visiteurId;

        public FrmListeRapports(string id)
        {
            InitializeComponent();
            visiteurId = id;
        }

        private void FrmListeRapports_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=BB\BERRI;Initial Catalog=gsbrapports2016;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = @"SELECT id, date, bilan, motif FROM rapport WHERE idVisiteur = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", visiteurId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewRapports.DataSource = dt;
                }
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            if (dataGridViewRapports.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Fichiers XML (*.xml)|*.xml";
                    sfd.Title = "Exporter les rapports au format XML";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        dt.TableName = "Rapports";
                        dt.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);
                        MessageBox.Show("Exportation réussie.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune donnée à exporter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
