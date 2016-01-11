using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    public class Commande
    {

        private int numCommande;
        private Utilisateur unUser;
        private DateTime dateCommande;

        public Commande()
        {

        }

        public int NumCommande
        {
            get
            {
                return numCommande;
            }

            set
            {
                numCommande = value;
            }
        }


        public DateTime DateCommande
        {
            get
            {
                return dateCommande;
            }

            set
            {
                dateCommande = value;
            }
        }

        internal Utilisateur UnUser
        {
            get
            {
                return unUser;
            }

            set
            {
                unUser = value;
            }
        }

        public Commande(int NumCommande, Utilisateur UnUser, DateTime DateCommande)
        {
            this.dateCommande = DateCommande;
            this.numCommande = NumCommande;
            this.unUser = UnUser;
        }



    }
}
