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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void gererLesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rapportsVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmGestionVisiteurs();
            f.Show();
        }
    }
}
