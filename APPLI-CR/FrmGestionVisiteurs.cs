using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLI_CR
{
    public partial class FrmGestionVisiteurs : Form
    {
        public FrmGestionVisiteurs()
        {
            InitializeComponent();
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
    }
}
