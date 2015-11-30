using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet
{
    public partial class BiblioNet : Form
    {
        public BiblioNet()
        {
            InitializeComponent();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUtilisateurs MaFenetreUtilisateur = new GestionUtilisateurs();
            MaFenetreUtilisateur.MdiParent = this;
            MaFenetreUtilisateur.Show();
        }
    }
}
