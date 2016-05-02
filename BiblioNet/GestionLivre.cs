using BiblioNet.Classes;
using BiblioNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet
{
    public partial class GestionLivre : Form
    {
        Collection<Livre> collLivre;
        int NumCommandeCourante;
        public GestionLivre()
        {
            InitializeComponent();
        }
        private void GestionLivre_Load(object sender, EventArgs e)
        {
            try
            {
                collLivre = new Collection<Livre>();
                collLivre = M_Livre.getLivres();
                NumCommandeCourante = 1;
               /* AffecterValeurs(collCommande[NumCommandeCourante - 1]);
                collCommande[0].UnUser.MesCommandesUser = M_Commande.getCommandesUser(collCommande[0].UnUser);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

    }
}
