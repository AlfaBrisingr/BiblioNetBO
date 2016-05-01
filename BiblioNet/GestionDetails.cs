using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet
{
    public partial class GestionDetails : Form
    {
        private DataTable _dt;
        public GestionDetails(DataTable dtExt)
        {
            InitializeComponent();
            try
            {
                _dt = dtExt;
                TableauLivre.DataSource = _dt;
                if (TableauLivre.Rows.Count == 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Close();
                MessageBox.Show("Erreur : colonnes vide");
            }
        }

        private void GestionDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
