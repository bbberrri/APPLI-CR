namespace APPLI_CR
{
    partial class FrmGestionVisiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VisiteursDataGridView = new System.Windows.Forms.DataGridView();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceGestionVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.gsbrapports2016DataSet = new APPLI_CR.gsbrapports2016DataSet();
            this.visiteurTableAdapter = new APPLI_CR.gsbrapports2016DataSetTableAdapters.visiteurTableAdapter();
            this.visiteurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVisiteur = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisiteursDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGestionVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // VisiteursDataGridView
            // 
            this.VisiteursDataGridView.AllowUserToAddRows = false;
            this.VisiteursDataGridView.AllowUserToDeleteRows = false;
            this.VisiteursDataGridView.AutoGenerateColumns = false;
            this.VisiteursDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisiteursDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VisiteursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisiteursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.mdpDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn});
            this.VisiteursDataGridView.DataSource = this.visiteurBindingSource;
            this.VisiteursDataGridView.Location = new System.Drawing.Point(12, 12);
            this.VisiteursDataGridView.Name = "VisiteursDataGridView";
            this.VisiteursDataGridView.ReadOnly = true;
            this.VisiteursDataGridView.Size = new System.Drawing.Size(513, 361);
            this.VisiteursDataGridView.TabIndex = 0;
            this.VisiteursDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataSource = this.visiteurBindingSource1;
            // 
            // bdgSourceGestionVisiteurs
            // 
            this.bdgSourceGestionVisiteurs.DataSource = this.gsbrapports2016DataSet;
            this.bdgSourceGestionVisiteurs.Position = 0;
            this.bdgSourceGestionVisiteurs.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // gsbrapports2016DataSet
            // 
            this.gsbrapports2016DataSet.DataSetName = "gsbrapports2016DataSet";
            this.gsbrapports2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteurTableAdapter
            // 
            this.visiteurTableAdapter.ClearBeforeFill = true;
            // 
            // visiteurBindingSource1
            // 
            this.visiteurBindingSource1.DataSource = this.visiteurBindingSource2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdpDataGridViewTextBoxColumn
            // 
            this.mdpDataGridViewTextBoxColumn.DataPropertyName = "mdp";
            this.mdpDataGridViewTextBoxColumn.HeaderText = "mdp";
            this.mdpDataGridViewTextBoxColumn.Name = "mdpDataGridViewTextBoxColumn";
            this.mdpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            this.dateEmbaucheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visiteurBindingSource2
            // 
            this.visiteurBindingSource2.DataMember = "visiteur";
            this.visiteurBindingSource2.DataSource = this.bdgSourceGestionVisiteurs;
            // 
            // btnAddVisiteur
            // 
            this.btnAddVisiteur.Location = new System.Drawing.Point(636, 326);
            this.btnAddVisiteur.Name = "btnAddVisiteur";
            this.btnAddVisiteur.Size = new System.Drawing.Size(82, 33);
            this.btnAddVisiteur.TabIndex = 1;
            this.btnAddVisiteur.Text = "Ajouter";
            this.btnAddVisiteur.UseVisualStyleBackColor = true;
            this.btnAddVisiteur.Click += new System.EventHandler(this.btnAddVisiteur_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(636, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(88, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(533, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(533, 82);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(636, 79);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(88, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(533, 132);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 12;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(636, 129);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(104, 20);
            this.txtAdresse.TabIndex = 11;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(533, 182);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(63, 13);
            this.lblCP.TabIndex = 14;
            this.lblCP.Text = "Code postal";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(636, 179);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(77, 20);
            this.txtCP.TabIndex = 13;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(533, 231);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 16;
            this.lblVille.Text = "Ville";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(636, 228);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(88, 20);
            this.txtVille.TabIndex = 15;
            // 
            // dtpDateEmbauche
            // 
            this.dtpDateEmbauche.Location = new System.Drawing.Point(636, 278);
            this.dtpDateEmbauche.Name = "dtpDateEmbauche";
            this.dtpDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEmbauche.TabIndex = 17;
            this.dtpDateEmbauche.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(533, 281);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.lblDateEmbauche.TabIndex = 18;
            this.lblDateEmbauche.Text = "Date d\'embauche";
            // 
            // FrmGestionVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 410);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.dtpDateEmbauche);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAddVisiteur);
            this.Controls.Add(this.VisiteursDataGridView);
            this.Name = "FrmGestionVisiteurs";
            this.Text = "Gestion des visiteurs";
            this.Load += new System.EventHandler(this.FrmGestionVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisiteursDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGestionVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VisiteursDataGridView;
        private System.Windows.Forms.BindingSource bdgSourceGestionVisiteurs;
        private gsbrapports2016DataSet gsbrapports2016DataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private gsbrapports2016DataSetTableAdapters.visiteurTableAdapter visiteurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource visiteurBindingSource1;
        private System.Windows.Forms.BindingSource visiteurBindingSource2;
        private System.Windows.Forms.Button btnAddVisiteur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
        private System.Windows.Forms.Label lblDateEmbauche;
    }
}