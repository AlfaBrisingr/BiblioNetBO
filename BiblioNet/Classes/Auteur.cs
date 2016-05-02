using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    class Auteur
    {
        private int NumAuteur;
        private string NonAuteur;

        public Auteur(int NumAuteur ,String NonAuteu) {
            this.NumAuteur = NumAuteur;
            this.NonAuteur = NonAuteu;
        }
        public int NumAuteur1
        {
            get
            {
                return NumAuteur;
            }

            set
            {
                NumAuteur = value;
            }
        }

        public string NonAuteur1
        {
            get
            {
                return NonAuteur;
            }

            set
            {
                NonAuteur = value;
            }
        }
    }
}
