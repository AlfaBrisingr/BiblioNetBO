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
            BoxEdition.Text = unlivre.UneEdition.NomEdition1.ToString();
            BoxGenre.Text = unlivre.UnGenre1.NonGenre1.ToString();
            LabelNbPage.Text = collLivre.Count.ToString();
            LabelPagueCourent.Text = NumLivreCourante.ToString();
            VerouillerBouton();
        }
        public void VerouillerBouton()
        {
            if(NumLivreCourante == 1)
            {
               buttonDebut.Enabled = false;
               buttonFin.Enabled = true;
               buttonPrecedent.Enabled = false;
               buttonSuivant.Enabled = true;
            }
            else
            {
                if ((NumLivreCourante == 1) && (NumLivreCourante == collLivre.Count))
                {
                    buttonDebut.Enabled = false;
                    buttonFin.Enabled = false;
                    buttonPrecedent.Enabled = false;
                    buttonSuivant.Enabled = false;
                }
                else
                {
                    if (NumLivreCourante == collLivre.Count)
                    {
                        buttonDebut.Enabled = true;
                        buttonFin.Enabled = false;
                        buttonPrecedent.Enabled = true;
                        buttonSuivant.Enabled = false;
                    }
                    else
                    {
                        buttonDebut.Enabled = true;
                        buttonFin.Enabled = true;
                        buttonPrecedent.Enabled = true;
                        buttonSuivant.Enabled = true;
                    }
                }
             }
           }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            NumLivreCourante = NumLivreCourante + 1;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            NumLivreCourante = NumLivreCourante - 1;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            NumLivreCourante = 1;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            NumLivreCourante = collLivre.Count;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }
    }
           
    }
    

