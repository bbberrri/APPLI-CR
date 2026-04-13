namespace APPLI_CR
{
    partial class FrmListeRapports
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
            this.dataGridViewRapports = new System.Windows.Forms.DataGridView();
            this.btnExportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRapports
            // 
            this.dataGridViewRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapports.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRapports.Name = "dataGridViewRapports";
            this.dataGridViewRapports.Size = new System.Drawing.Size(688, 409);
            this.dataGridViewRapports.TabIndex = 0;
            // 
            // btnExportXML
            // 
            this.btnExportXML.Location = new System.Drawing.Point(271, 427);
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(159, 36);
            this.btnExportXML.TabIndex = 1;
            this.btnExportXML.Text = "Export XML";
            this.btnExportXML.UseVisualStyleBackColor = true;
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // FrmListeRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 468);
            this.Controls.Add(this.btnExportXML);
            this.Controls.Add(this.dataGridViewRapports);
            this.Name = "FrmListeRapports";
            this.Text = "Liste des rapports";
            this.Load += new System.EventHandler(this.FrmListeRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRapports;
        private System.Windows.Forms.Button btnExportXML;
    }
}