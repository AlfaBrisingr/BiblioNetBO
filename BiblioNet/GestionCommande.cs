using BiblioNet.Classes;
using BiblioNet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet
{
    public partial class GestionCommande : Form
    {
        Collection<Commande> collCommande;
        int NumCommandeCourante;

        public GestionCommande()
        {
            InitializeComponent();
        }
      
        private void GestionCommande_Load(object sender, EventArgs e)
        {
            try
            {
                collCommande = new Collection<Commande>();
                collCommande = M_Commande.getCommandes();
                NumCommandeCourante = 1;
                AffecterValeurs(collCommande[NumCommandeCourante -1]);
                collCommande[0].UnUser.MesCommandesUser = M_Commande.getCommandesUser(collCommande[0].UnUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void AffecterValeurs(Commande uneCommande) {
            LblNom.Text = uneCommande.UnUser.Nom;
            LblPrenom.Text = uneCommande.UnUser.Prenom;
            LblComande.Text = uneCommande.NumCommande.ToString();


            LblCourant.Text = (NumCommandeCourante).ToString();
            LblMaximum.Text = collCommande.Count.ToString();

            VerouillerBouton();
        }

        public void VerouillerBouton()
        {
            if (collCommande.Count == 0)
            {
                buttonDebut.Enabled = false;
                buttonFin.Enabled = false;
                buttonPrecedent.Enabled = false;
                buttonSuivant.Enabled = false;
            }
            else
            {
                if ((NumCommandeCourante == 1 ) && (NumCommandeCourante == collCommande.Count))
                {
                    buttonDebut.Enabled = false;
                    buttonFin.Enabled = false;
                    buttonPrecedent.Enabled = false;
                    buttonSuivant.Enabled = false;
                }
                else
                {
                    if (NumCommandeCourante == 1)
                    {
                        buttonDebut.Enabled = false;
                        buttonFin.Enabled = true;
                        buttonPrecedent.Enabled = false;
                        buttonSuivant.Enabled = true;
                    }
                    else
                    {
                        if (NumCommandeCourante == collCommande.Count)
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
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            NumCommandeCourante = 1;
            AffecterValeurs(collCommande[NumCommandeCourante - 1]);
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            NumCommandeCourante = NumCommandeCourante - 1;
            AffecterValeurs(collCommande[NumCommandeCourante - 1]);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            NumCommandeCourante = NumCommandeCourante + 1;
            AffecterValeurs(collCommande[NumCommandeCourante - 1]);
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            NumCommandeCourante = collCommande.Count;
            AffecterValeurs(collCommande[NumCommandeCourante - 1]);
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            var MaFenetreDetails = new GestionDetails(M_Quantite.getQuantitebyCommande(NumCommandeCourante));
            MaFenetreDetails.Show();
            MaFenetreDetails.Text = "Les détails de la commande "+ NumCommandeCourante; 
        }
    }
}
