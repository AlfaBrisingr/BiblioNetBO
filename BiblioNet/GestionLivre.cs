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
        int TokenMandA;
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
            BoutonModifier.Enabled = true;
            BoutonValider.Enabled = false;
            BoutonAjouter.Enabled = true;
            BoutonAnnuler.Enabled = false;
            BoxNomLivre.Enabled = false;
            BoxISBN.Enabled = false;
            BoxNonAuteur.Enabled = false;
            BoxQuantiteStock.Enabled = false;
            BoxDateSortie.Enabled = false;
            BoxTarif.Enabled = false;
            BoxResume.Enabled = false;
            BoxLangue.Enabled = false;
            BoxEdition.Enabled = false;
            BoxGenre.Enabled = false;
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

        private void BoutonModifier_Click(object sender, EventArgs e)
        {
            buttonDebut.Enabled = false;
            buttonFin.Enabled = false;
            buttonPrecedent.Enabled = false;
            buttonSuivant.Enabled = false;
            BoutonModifier.Enabled = false;
            BoutonValider.Enabled = true;
            BoutonAjouter.Enabled = false;
            BoutonAnnuler.Enabled = true;
            BoxNomLivre.Enabled = false;
            BoxISBN.Enabled = false;
            BoxNonAuteur.Enabled = false;
            BoxQuantiteStock.Enabled = true;
            BoxDateSortie.Enabled = false;
            BoxTarif.Enabled = true;
            BoxResume.Enabled = true;
            BoxLangue.Enabled = false;
            BoxEdition.Enabled = false;
            BoxGenre.Enabled = false;
            TokenMandA = 1;
        }

        private void BoutonAjouter_Click(object sender, EventArgs e)
        {
            buttonDebut.Enabled = false;
            buttonFin.Enabled = false;
            buttonPrecedent.Enabled = false;
            buttonSuivant.Enabled = false;
            BoutonModifier.Enabled = false;
            BoutonValider.Enabled = true;
            BoutonAjouter.Enabled = false;
            BoutonAnnuler.Enabled = true;
            BoxNomLivre.Enabled = true;
            BoxISBN.Enabled = true;
            BoxNonAuteur.Enabled = true;
            BoxQuantiteStock.Enabled = true;
            BoxDateSortie.Enabled = true;
            BoxTarif.Enabled = true;
            BoxResume.Enabled = true;
            BoxLangue.Enabled = true;
            BoxEdition.Enabled = true;
            BoxGenre.Enabled = true;
            labNoLivre.Text = "x";
            BoxISBN.Text = "";
            BoxNomLivre.Text = "";
            BoxNonAuteur.Text = "";
            BoxQuantiteStock.Text = "";
            BoxDateSortie.Text = "";
            BoxTarif.Text = "";
            BoxResume.Text = "";
            BoxLangue.Text = "";
            BoxEdition.Text = "";
            BoxGenre.Text = "";
            LabelNbPage.Text = "X";
            LabelPagueCourent.Text ="X";
        }

        private void BoutonAnnuler_Click(object sender, EventArgs e)
        {
            BoutonModifier.Enabled = true;
            BoutonValider.Enabled = false;
            BoutonAjouter.Enabled = true;
            BoutonAnnuler.Enabled = false;
            BoxNomLivre.Enabled = false;
            BoxISBN.Enabled = false;
            BoxNonAuteur.Enabled = false;
            BoxQuantiteStock.Enabled = false;
            BoxDateSortie.Enabled = false;
            BoxTarif.Enabled = false;
            BoxResume.Enabled = false;
            BoxLangue.Enabled = false;
            BoxEdition.Enabled = false;
            BoxGenre.Enabled = false;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }

        private void BoutonValider_Click(object sender, EventArgs e)
        {
            if (TokenMandA == 1)
            {
                try
                {

                    Livre unlivre = new Livre(int.Parse(labNoLivre.Text), BoxISBN.Text, BoxNomLivre.Text,new Auteur(int.Parse(collLivre[NumLivreCourante - 1].UnAuteur1.NumAuteur1.ToString()), BoxNonAuteur.Text),int.Parse(BoxQuantiteStock.Text),BoxDateSortie.Text,BoxTarif.Text,BoxResume.Text,BoxLangue.Text, collLivre[NumLivreCourante - 1].Couverture.ToString(),new Edition(int.Parse(collLivre[NumLivreCourante - 1].UneEdition.NumEdition1.ToString()),BoxEdition.Text),new Genre(int.Parse(collLivre[NumLivreCourante-1].UnGenre1.NumGenre1.ToString()),BoxGenre.Text));
                    M_Livre.ModifLivre(unlivre);
                    reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                
               
            }
            else
            {
                reset();
               
            }
        }
        private void reset()
        {
            collLivre = new Collection<Livre>();
            collLivre = M_Livre.getLivre();
            BoutonModifier.Enabled = true;
            BoutonValider.Enabled = false;
            BoutonAjouter.Enabled = true;
            BoutonAnnuler.Enabled = false;
            AffecterValeurs(collLivre[NumLivreCourante - 1]);
        }

    }
           
    }
    

