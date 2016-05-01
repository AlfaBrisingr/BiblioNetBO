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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCommande MaFenetreCommande = new GestionCommande();
            MaFenetreCommande.MdiParent = this;
            MaFenetreCommande.Show();
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionLivre MaFenetreLivre = new GestionLivre();
            MaFenetreLivre.MdiParent = this;
            MaFenetreLivre.Show();
        }
    }
}
