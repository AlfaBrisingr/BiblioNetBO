using BiblioNet.Classes;
using BiblioNet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet
{
    public partial class GestionUtilisateurs : Form
    {

        Collection<Utilisateur> collUser;

        private DataTable datatable = new DataTable();

        public GestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void GestionUtilisateurs_Load(object sender, EventArgs e)
        {
            try
            {
                datatable = M_Utilisateur.getLesUser();
                TableauUser.DataSource = datatable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void AffecterValeurs(Utilisateur unUser)
        {
            BoxAdresse.Text = unUser.Adresse;
            BoxCp.Text = unUser.CodePostal;
            BoxMail.Text = unUser.AdresseMail;
            BoxMDP.Text = unUser.Password;
            BoxNom.Text = unUser.Nom;
            BoxPrenom.Text = unUser.Prenom;
            BoxVille.Text = unUser.Ville;
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {

                BoxNom.Enabled = true;
                BoxPrenom.Enabled = true;
                BoxMDP.Enabled = false;
                BoxMail.Enabled = true;
                BoxCp.Enabled = true;
                BoxAdresse.Enabled = true;
                BoxVille.Enabled = true;
                BtnSupprimer.Enabled = false;
                BtnModifier.Enabled = false;
                BtnValider.Enabled = true;
                BtnAnnuler.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                BoxNom.Enabled = false;
                BoxPrenom.Enabled = false;
                BoxMDP.Enabled = false;
                BoxMail.Enabled = false;
                BoxCp.Enabled = false;
                BoxAdresse.Enabled = false;
                BoxVille.Enabled = false;
                BtnSupprimer.Enabled = true;
                BtnModifier.Enabled = true;
                MessageBox.Show(LblCode.Text);
                Utilisateur UnUser = new Utilisateur(int.Parse(LblCode.Text), BoxNom.Text, BoxPrenom.Text, BoxMDP.Text, BoxMail.Text, BoxAdresse.Text, BoxCp.Text, BoxVille.Text);
                M_Utilisateur.ModifUser(UnUser);
                TableauUser.DataSource = M_Utilisateur.getLesUser();
                BtnAnnuler.Enabled = false;
                BtnValider.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                BoxNom.Enabled = false;
                BoxPrenom.Enabled = false;
                BoxMDP.Enabled = false;
                BoxMail.Enabled = false;
                BoxCp.Enabled = false;
                BoxAdresse.Enabled = false;
                BoxVille.Enabled = false;
                BtnSupprimer.Enabled = true;
                BtnModifier.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void ClickCellule(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int NumUser = int.Parse(TableauUser.CurrentRow.Cells[0].Value.ToString());
                LblCode.Text = NumUser.ToString();
                Utilisateur User = M_Utilisateur.getUser(NumUser);
                AffecterValeurs(User);
                BtnModifier.Enabled = true;
                BtnSupprimer.Enabled = true;
            }
            catch
            {

            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Voulez-vous supprimer l'utilisateur ?", "Suppression d'un Utilisateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    M_Utilisateur.SupprimerUser(new Utilisateur(int.Parse(LblCode.Text), BoxNom.Text, BoxPrenom.Text, BoxMDP.Text, BoxMail.Text, BoxAdresse.Text, BoxCp.Text, BoxVille.Text));
                    TableauUser.DataSource = M_Utilisateur.getLesUser();

                }
                else
                {
                    MessageBox.Show("Opération annulée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
            }
            finally
            {
                bdd.GestBiblioNetConn.Close();
            }
        }
    }
}
