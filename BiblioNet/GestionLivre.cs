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
        int NumLivreCourante;
        public GestionLivre()
        {
            InitializeComponent();
        }

        private void GestionLivre_Load(object sender, EventArgs e)
        {
            try
            {
                collLivre = new Collection<Livre>();
                collLivre = M_Livre.getLivre();
                NumLivreCourante = 1;
                AffecterValeurs(collLivre[NumLivreCourante - 1]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }
        private void AffecterValeurs(Livre unlivre)
        {
            BoxResume.Text = unlivre.Resume1;
            VerouillerBouton();
        }
        public void VerouillerBouton()
        {
            buttonDebut.Enabled = false;
            buttonFin.Enabled = false;
            buttonPrecedent.Enabled = false;
            buttonSuivant.Enabled = false;
        }
    }
    }

