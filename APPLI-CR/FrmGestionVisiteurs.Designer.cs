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
            this.bdgSourceGestionVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.gsbrapports2016DataSet = new APPLI_CR.gsbrapports2016DataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new APPLI_CR.gsbrapports2016DataSetTableAdapters.visiteurTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VisiteursDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGestionVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
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
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn});
            this.VisiteursDataGridView.DataSource = this.visiteurBindingSource;
            this.VisiteursDataGridView.Location = new System.Drawing.Point(12, 12);
            this.VisiteursDataGridView.Name = "VisiteursDataGridView";
            this.VisiteursDataGridView.ReadOnly = true;
            this.VisiteursDataGridView.Size = new System.Drawing.Size(807, 294);
            this.VisiteursDataGridView.TabIndex = 0;
            this.VisiteursDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataMember = "visiteur";
            this.visiteurBindingSource.DataSource = this.bdgSourceGestionVisiteurs;
            // 
            // visiteurTableAdapter
            // 
            this.visiteurTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "Date d\'embauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            this.dateEmbaucheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmGestionVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 368);
            this.Controls.Add(this.VisiteursDataGridView);
            this.Name = "FrmGestionVisiteurs";
            this.Text = "Gestion des visiteurs";
            this.Load += new System.EventHandler(this.FrmGestionVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisiteursDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGestionVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
    }
}