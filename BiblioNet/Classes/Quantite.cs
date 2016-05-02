using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    class Quantite
    {
        private int noLivre;
        private int noCommande;
        private int quantiteprod;

        public Quantite()
        {

        }

        public int NoLivre
        {
            get
            {
                return noLivre;
            }

            set
            {
                noLivre = value;
            }
        }

        public int NoCommande
        {
            get
            {
                return noCommande;
            }

            set
            {
                noCommande = value;
            }
        }

        public int Quantiteprod
        {
            get
            {
                return quantiteprod;
            }

            set
            {
                quantiteprod = value;
            }
        }

        public Quantite(int NoLivre, int NoCommande, int QuantiteProd)
        {
            this.noLivre = NoLivre;
            this.noCommande = NoCommande;
            this.quantiteprod = QuantiteProd;
        }

        public int getLivre()
        {
            return this.noLivre;
        }

        public int getCommande()
        {
            return this.noCommande;
        }

        public int getQuantiteProd()
        {
            return this.quantiteprod;
        }
    }
}
