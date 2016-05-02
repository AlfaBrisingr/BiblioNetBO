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
        private int CodeISBN;
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

        public Livre() {
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

        public int CodeISBN1
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

        public string Auteur1
        {
            get
            {
                return Auteur;
            }

            set
            {
                Auteur = value;
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

        public string Langaque1
        {
            get
            {
                return Langaque;
            }

            set
            {
                Langaque = value;
            }
        }

        public string Edition1
        {
            get
            {
                return Edition;
            }

            set
            {
                Edition = value;
            }
        }

        public string Genre1
        {
            get
            {
                return Genre;
            }

            set
            {
                Genre = value;
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
    }
}
