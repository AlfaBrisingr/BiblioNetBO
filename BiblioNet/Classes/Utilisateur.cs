using BiblioNet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    public class Utilisateur
    {
        private int numUser;
        private string nom;
        private string prenom;
        private string password;
        private string adresseMail;
        private string adresse;
        private string codePostal;
        private string ville;
        private Collection<Commande> mesCommandesUser;

        public Utilisateur()
        {
            mesCommandesUser = new Collection<Commande>();
        }

        public int NumUser
        {
            get
            {
                return numUser;
            }

            set
            {
                numUser = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string AdresseMail
        {
            get
            {
                return adresseMail;
            }

            set
            {
                adresseMail = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
  
        }

        public Collection<Commande> MesCommandesUser
        {
            get
            {
                return mesCommandesUser;
            }

            set
            {
                mesCommandesUser = value;
            }
        }

        public Utilisateur(int Num, string NomU, string PrenomU, string mdp, string mail, string AdresseU, string CodeU, string VilleU)
        {
            this.numUser = Num;
            this.nom = NomU;
            this.prenom = PrenomU;
            this.password = mdp;
            this.adresseMail = mail;
            this.adresse = AdresseU;
            this.codePostal = CodeU;
            this.ville = VilleU;
            mesCommandesUser = new Collection<Commande>();
        }






    }
}

