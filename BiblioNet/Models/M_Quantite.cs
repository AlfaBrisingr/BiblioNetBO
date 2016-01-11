using BiblioNet.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet.Models
{
    class M_Quantite
    {
        public static Collection<Quantite> getQuantite()
        {
            Collection<Quantite> mesQuantites = new Collection<Quantite>();

            try
            {
                mesQuantites.Clear();
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM Quantite ";

                MySqlDataReader MonReaderQuantite;
                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MonReaderQuantite = Command1.ExecuteReader();

                Quantite nouvelleQuantite;
                while (MonReaderQuantite.Read())
                {
                    nouvelleQuantite = new Quantite(int.Parse(MonReaderQuantite[0].ToString()), int.Parse(MonReaderQuantite[1].ToString()), int.Parse(MonReaderQuantite[3].ToString()));
                    mesQuantites.Add(nouvelleQuantite);
                }
                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return mesQuantites;
        }
    }
}
