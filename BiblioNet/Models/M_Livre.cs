using MySql.Data.MySqlClient;
using BiblioNet.Classes;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet.Models
{
    class M_Livre
    {
        public static Collection<Livre> getLivre()
        {
            Collection<Livre> mesLivres = new Collection<Livre>();

            try
            {
                mesLivres.Clear();
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM Livre INNER JOIN Auteur ON Auteur.NumAuteur = Livre.NumAuteur INNER JOIN Edition ON Edition.NumEdition = Livre.NoEdition INNER JOIN Genre ON Genre.NumGenre = Livre.NoGenre";

                MySqlDataReader MonReaderLivre;
                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MonReaderLivre = Command1.ExecuteReader();

                Livre nouvelleLivre;
                while (MonReaderLivre.Read())
                {
                    nouvelleLivre = new Livre(int.Parse(MonReaderLivre[0].ToString()), MonReaderLivre[1].ToString(), MonReaderLivre[2].ToString(), new Auteur(int.Parse(MonReaderLivre[12].ToString()), MonReaderLivre[13].ToString()));
                    mesLivres.Add(nouvelleLivre);
                }
                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                bdd.GestBiblioNetConn.Close();
            }

            return mesLivres;
        }

    }
}
