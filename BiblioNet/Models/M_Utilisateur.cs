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
    class M_Utilisateur
    {

        public static Collection<Utilisateur> getUser()
        {
            Collection<Utilisateur> mesUsers = new Collection<Utilisateur>();

            try
            {
                mesUsers.Clear();
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM utilisateur";

                MySqlDataReader MonReaderUtilisateur;
                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MonReaderUtilisateur = Command1.ExecuteReader();

                Utilisateur nouveauUser;
                while (MonReaderUtilisateur.Read())
                {
                    nouveauUser = new Utilisateur(int.Parse(MonReaderUtilisateur[0].ToString()), MonReaderUtilisateur[1].ToString(), MonReaderUtilisateur[2].ToString(), MonReaderUtilisateur[3].ToString(), MonReaderUtilisateur[4].ToString(), MonReaderUtilisateur[5].ToString(), MonReaderUtilisateur[6].ToString(), MonReaderUtilisateur[7].ToString());
                    mesUsers.Add(nouveauUser);
                }

                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return mesUsers;
        }

        public static void AjoutUser(Utilisateur unUser)
        {
            bdd.GestBiblioNetConn.Open();

            String ReqSQL = "INSERT INTO utilisateur(Nom,Prenom,Password,AdresseMail,Adresse,CodePostal,Ville) VALUES (?,?,?,?,?,?,?)";

            MySqlCommand Command1 = new MySqlCommand(ReqSQL, bdd.GestBiblioNetConn);

            MySqlParameter Param1 = Command1.Parameters.Add("@Nom", MySqlDbType.VarChar);
            MySqlParameter Param2 = Command1.Parameters.Add("@Prenom", MySqlDbType.VarChar);
            MySqlParameter Param3 = Command1.Parameters.Add("@Password", MySqlDbType.VarChar);
            MySqlParameter Param4 = Command1.Parameters.Add("@AdresseMail", MySqlDbType.VarChar);
            MySqlParameter Param5 = Command1.Parameters.Add("@Adresse", MySqlDbType.VarChar);
            MySqlParameter Param6 = Command1.Parameters.Add("@CodePostal", MySqlDbType.VarChar);
            MySqlParameter Param7 = Command1.Parameters.Add("@Ville", MySqlDbType.VarChar);



            Param1.Value = unUser.Nom;
            Param2.Value = unUser.Prenom;
            Param3.Value = unUser.Password;
            Param4.Value = unUser.AdresseMail;
            Param5.Value = unUser.Adresse;
            Param6.Value = unUser.CodePostal;
            Param7.Value = unUser.Ville;

            Command1.ExecuteNonQuery();

            bdd.GestBiblioNetConn.Close();
        }

        public static void ModifUser(Utilisateur unUser)
        {
            String SQL = "UPDATE utilisateur SET Nom = ?,Prenom = ?,Password = ?,AdresseMail = ?,Adresse = ?,CodePostal = ?,Ville = ?";

            bdd.GestBiblioNetConn.Open();

            MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);

            MySqlParameter Param1 = Command1.Parameters.Add("@Nom", MySqlDbType.VarChar);
            MySqlParameter Param2 = Command1.Parameters.Add("@Prenom", MySqlDbType.VarChar);
            MySqlParameter Param3 = Command1.Parameters.Add("@Password", MySqlDbType.VarChar);
            MySqlParameter Param4 = Command1.Parameters.Add("@AdresseMail", MySqlDbType.VarChar);
            MySqlParameter Param5 = Command1.Parameters.Add("@Adresse", MySqlDbType.VarChar);
            MySqlParameter Param6 = Command1.Parameters.Add("@CodePostal", MySqlDbType.VarChar);
            MySqlParameter Param7 = Command1.Parameters.Add("@Ville", MySqlDbType.VarChar);



            Param1.Value = unUser.Nom;
            Param2.Value = unUser.Prenom;
            Param3.Value = unUser.Password;
            Param4.Value = unUser.AdresseMail;
            Param5.Value = unUser.Adresse;
            Param6.Value = unUser.CodePostal;
            Param7.Value = unUser.Ville;


            Command1.ExecuteNonQuery();

            bdd.GestBiblioNetConn.Close();
        }

        public static void SupprimerUser(Utilisateur unUser)
        {
            String SQL = "DELETE FROM utilisateur WHERE NumUser = ?";

            bdd.GestBiblioNetConn.Open();

            MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);

            MySqlParameter Param1 = Command1.Parameters.Add("@NumUser", MySqlDbType.VarChar);

            Param1.Value = unUser.NumUser;


            Command1.ExecuteNonQuery();

            bdd.GestBiblioNetConn.Close();
        }
    }
}
