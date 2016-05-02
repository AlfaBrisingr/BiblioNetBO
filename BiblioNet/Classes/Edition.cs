using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioNet.Classes
{
    class Edition
    {
        private int NumEdition;
        private String NomEdition;
        public Edition(int NumEditio,String NomEditio)
        {
            this.NumEdition = NumEditio;
            this.NomEdition = NomEditio;
        }

        public int NumEdition1
        {
            get
            {
                return NumEdition;
            }

            set
            {
                NumEdition = value;
            }
        }

        public string NomEdition1
        {
            get
            {
                return NomEdition;
            }

            set
            {
                NomEdition = value;
            }
        }
    }
}
