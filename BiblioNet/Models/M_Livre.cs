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
                    nouvelleLivre = new Livre(int.Parse(MonReaderLivre[0].ToString()), MonReaderLivre[1].ToString(), MonReaderLivre[2].ToString(), new Auteur(int.Parse(MonReaderLivre[12].ToString()), MonReaderLivre[13].ToString()), int.Parse(MonReaderLivre[4].ToString()), MonReaderLivre[5].ToString(), MonReaderLivre[6].ToString(), MonReaderLivre[7].ToString(), MonReaderLivre[8].ToString(), MonReaderLivre[9].ToString(), new Edition(int.Parse(MonReaderLivre[14].ToString()), MonReaderLivre[15].ToString()), new Genre(int.Parse(MonReaderLivre[16].ToString()), MonReaderLivre[17].ToString()));
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
        public static void ModifLivre(Livre unlivre)
        {
            String SQL = "UPDATE Livre SET numLivre = ?,CodeISBN = ?, Password = ?,AdresseMail = ?,Adresse = ?,CodePostal = ?,Ville = ? WHERE NumUser = ?";

            bdd.GestBiblioNetConn.Open();

            MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);

            MySqlParameter Param1 = Command1.Parameters.Add("@Nom", MySqlDbType.VarChar);
            MySqlParameter Param2 = Command1.Parameters.Add("@Prenom", MySqlDbType.VarChar);
            MySqlParameter Param3 = Command1.Parameters.Add("@Password", MySqlDbType.VarChar);
            MySqlParameter Param4 = Command1.Parameters.Add("@AdresseMail", MySqlDbType.VarChar);
            MySqlParameter Param5 = Command1.Parameters.Add("@Adresse", MySqlDbType.VarChar);
            MySqlParameter Param6 = Command1.Parameters.Add("@CodePostal", MySqlDbType.VarChar);
            MySqlParameter Param7 = Command1.Parameters.Add("@Ville", MySqlDbType.VarChar);
            MySqlParameter Param8 = Command1.Parameters.Add("@NumUser", MySqlDbType.Int16);



            Param1.Value = unUser.Nom;
            Param2.Value = unUser.Prenom;
            Param3.Value = unUser.Password;
            Param4.Value = unUser.AdresseMail;
            Param5.Value = unUser.Adresse;
            Param6.Value = unUser.CodePostal;
            Param7.Value = unUser.Ville;
            Param8.Value = unUser.NumUser;


            Command1.ExecuteNonQuery();

            bdd.GestBiblioNetConn.Close();
        }


    }
}
