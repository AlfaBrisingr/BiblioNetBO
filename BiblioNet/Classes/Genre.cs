using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    class Genre
    {
        private int NumGenre;
        private String NonGenre;
        public Genre (int NumGenr,String NomGenr)
            {
            this.NumGenre = NumGenr;
            this.NonGenre = NomGenr;
            }

        public int NumGenre1
        {
            get
            {
                return NumGenre;
            }

            set
            {
                NumGenre = value;
            }
        }

        public string NonGenre1
        {
            get
            {
                return NonGenre;
            }

            set
            {
                NonGenre = value;
            }
        }
    }
}
