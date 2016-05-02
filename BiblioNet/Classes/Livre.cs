using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    class Livre
    {
        private int numLivre;
        private String CodeISBN;
        private String NonLivre;
        private Auteur UnAuteur;
        private int QuantiteStock;
        private DateTime DateSortie;
        private int Tarif;
        private String Resume;
        private String Langue;
        private String couverture;
        private Edition uneEdition;
        private Genre UnGenre;

        public Livre(int numLivre ,String CodeISBN, String NonLivre, Auteur UnAuteur, int QuantiteStock, DateTime DateSortie, int Tarif, String Resume, String Langue,String couverture, Edition uneEdition, Genre UnGenre)
        {
            this.numLivre = numLivre;
            this.CodeISBN = CodeISBN;
            this.NonLivre = NonLivre;
            this.QuantiteStock = QuantiteStock;
            this.DateSortie = DateSortie;
            this.Tarif = Tarif;
            this.Resume = Resume;
            this.Langue = Langue;
            this.couverture = couverture;
            this.uneEdition = uneEdition;
            this.UnGenre = UnGenre;

        }
        public int NumLivre
        {

            get
            {
                return numLivre;
            }

            set
            {
                numLivre = value;
            }
        }

        public String CodeISBN1
        {
            get
            {
                return CodeISBN;
            }

            set
            {
                CodeISBN = value;
            }
        }

        public string NonLivre1
        {
            get
            {
                return NonLivre;
            }

            set
            {
                NonLivre = value;
            }
        }

        internal Auteur UnAuteur1
        {
            get
            {
                return UnAuteur;
            }

            set
            {
                UnAuteur = value;
            }
        }

        public int QuantiteStock1
        {
            get
            {
                return QuantiteStock;
            }

            set
            {
                QuantiteStock = value;
            }
        }

        public DateTime DateSortie1
        {
            get
            {
                return DateSortie;
            }

            set
            {
                DateSortie = value;
            }
        }

        public int Tarif1
        {
            get
            {
                return Tarif;
            }

            set
            {
                Tarif = value;
            }
        }

        public string Resume1
        {
            get
            {
                return Resume;
            }

            set
            {
                Resume = value;
            }
        }

        public string Langue1
        {
            get
            {
                return Langue;
            }

            set
            {
                Langue = value;
            }
        }

        public string Couverture
        {
            get
            {
                return couverture;
            }

            set
            {
                couverture = value;
            }
        }

        internal Edition UneEdition
        {
            get
            {
                return uneEdition;
            }

            set
            {
                uneEdition = value;
            }
        }

        internal Genre UnGenre1
        {
            get
            {
                return UnGenre;
            }

            set
            {
                UnGenre = value;
            }
        }

     
    }
}
       
