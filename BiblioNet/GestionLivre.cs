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
            labNoLivre.Text =unlivre.NumLivre.ToString();
            BoxISBN.Text = unlivre.CodeISBN1.ToString();
            BoxNomLivre.Text = unlivre.NonLivre1.ToString();
            BoxNonAuteur.Text = unlivre.UnAuteur1.NonAuteur1.ToString();
            BoxQuantiteStock.Text = unlivre.QuantiteStock1.ToString();
            BoxDateSortie.Text = unlivre.DateSortie1.ToString();
            BoxTarif.Text = unlivre.Tarif1.ToString();
            BoxResume.Text = unlivre.Resume1.ToString();
            BoxLangue.Text = unlivre.Langue1.ToString();
            BoxEdition.Text = unlivre.UneEdition.ToString();
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

