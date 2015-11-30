using BiblioNet.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

                String SQL = "SELECT * FROM Utilisateur";

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


        public static void ModifUser(Utilisateur unUser)
        {
            String SQL = "UPDATE Utilisateur SET Nom = ?,Prenom = ?, Password = ?,AdresseMail = ?,Adresse = ?,CodePostal = ?,Ville = ? WHERE NumUser = ?";

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

        public static void SupprimerUser(Utilisateur unUser)
        {
            String SQL = "DELETE FROM Utilisateur WHERE NumUser = ?";

            bdd.GestBiblioNetConn.Open();

            MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);

            MySqlParameter Param1 = Command1.Parameters.Add("@NumUser", MySqlDbType.VarChar);

            Param1.Value = unUser.NumUser;


            Command1.ExecuteNonQuery();

            bdd.GestBiblioNetConn.Close();
        }

        static public DataTable getLesUser()
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable("Utilisateur");
            try
            {
                bdd.GestBiblioNetConn.Open();
                string SQL = "SELECT NumUser as 'Numero Utilisateur', Nom as 'Nom', Prenom as 'Prenom', Password as 'Mot de Passe', AdresseMail as 'Adresse Mail', Adresse as 'Adresse Postal', CodePostal as 'Code Postal', Ville as 'Ville' FROM Utilisateur ";

                MySqlDataAdapter da = new MySqlDataAdapter(SQL, bdd.GestBiblioNetConn);

                da.Fill(dataset, "Utilisateur");
                datatable = dataset.Tables["Utilisateur"];
              if (datatable.Rows.Count == 0)
                throw new Exception("Aucun Utilisateur !");
                bdd.GestBiblioNetConn.Close();
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                bdd.GestBiblioNetConn.Close();
            }
            return datatable;
        }

        public static Utilisateur getUser(int NumUser)
        {
            Utilisateur unUser = new Utilisateur();
            try
            {
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM Utilisateur WHERE NumUser = ?";

                MySqlDataReader MonReaderUtilisateur;
                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MySqlParameter Param1 = Command1.Parameters.Add("@NumUser", MySqlDbType.Int16);

                Param1.Value = NumUser;
                MonReaderUtilisateur = Command1.ExecuteReader();

                while (MonReaderUtilisateur.Read())
                {
                    unUser.NumUser = int.Parse(MonReaderUtilisateur[0].ToString());
                    unUser.Nom = MonReaderUtilisateur[1].ToString();
                    unUser.Prenom = MonReaderUtilisateur[2].ToString();
                    unUser.Password = MonReaderUtilisateur[3].ToString();
                    unUser.AdresseMail = MonReaderUtilisateur[4].ToString();
                    unUser.Adresse = MonReaderUtilisateur[5].ToString();
                    unUser.CodePostal = MonReaderUtilisateur[6].ToString();
                    unUser.Ville = MonReaderUtilisateur[7].ToString();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bdd.GestBiblioNetConn.Close();
            }

            return unUser;
        }
    }
}
