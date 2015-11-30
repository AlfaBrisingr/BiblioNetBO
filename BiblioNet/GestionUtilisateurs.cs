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
    public partial class GestionUtilisateurs : Form
    {

        Collection<Utilisateur> collUtilisateur;
        int NumUtilisateurCourante;

        public GestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            try
            {

                collUtilisateur = new Collection<Utilisateur>();
                collUtilisateur = M_Utilisateur.getUser();
                NumUtilisateurCourante = 1;
               /* AffecterValeurs(collUtilisateur[NumUtilisateurCourante - 1]);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void ListeUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeUtilisateur.Items.Add(MonReaderUtilisateur);
        }
    }
}
