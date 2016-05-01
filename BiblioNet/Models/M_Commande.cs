using MySql.Data.MySqlClient;
using BiblioNet.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioNet.Models
{
    class M_Commande
    {

        public static Collection<Commande> getCommandes()
        {
            Collection<Commande> mesCommandes = new Collection<Commande>();

            try
            {
                mesCommandes.Clear();
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM Commande INNER JOIN Utilisateur ON Utilisateur.NumUser = Commande.NoUsers";

                MySqlDataReader MonReaderCommande;
                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MonReaderCommande = Command1.ExecuteReader();

                Commande nouvelleCommande;
                while (MonReaderCommande.Read()) {
                    nouvelleCommande = new Commande(int.Parse(MonReaderCommande[0].ToString()), new Utilisateur(int.Parse(MonReaderCommande[1].ToString()), MonReaderCommande[4].ToString(), MonReaderCommande[5].ToString(), MonReaderCommande[6].ToString(), MonReaderCommande[7].ToString(), MonReaderCommande[8].ToString(), MonReaderCommande[9].ToString(), MonReaderCommande[10].ToString()), MonReaderCommande.GetDateTime(MonReaderCommande.GetOrdinal("DateCommande")));
                    mesCommandes.Add(nouvelleCommande);
                }
                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return mesCommandes;
        }

        public static Collection<Commande> getCommandesUser(Utilisateur unUser)
        {
            Collection<Commande> mesCommandes = new Collection<Commande>();

            try
            {
                mesCommandes.Clear();
                bdd.GestBiblioNetConn.Open();

                String SQL = "SELECT * FROM Commande INNER JOIN Utilisateur ON Utilisateur.NumUser = Commande.NoUsers WHERE NoUsers = ?";

                MySqlDataReader MonReaderCommande;

                MySqlCommand Command1 = new MySqlCommand(SQL, bdd.GestBiblioNetConn);
                MySqlParameter Param1 = Command1.Parameters.Add("@NumUser", MySqlDbType.Int16);
                Param1.Value = unUser.NumUser;

                MonReaderCommande = Command1.ExecuteReader();

                Commande nouvelleCommande;
                while (MonReaderCommande.Read())
                {
                    nouvelleCommande = new Commande(int.Parse(MonReaderCommande[0].ToString()), new Utilisateur(int.Parse(MonReaderCommande[1].ToString()), MonReaderCommande[4].ToString(), MonReaderCommande[5].ToString(), MonReaderCommande[6].ToString(), MonReaderCommande[7].ToString(), MonReaderCommande[8].ToString(), MonReaderCommande[9].ToString(), MonReaderCommande[10].ToString()), MonReaderCommande.GetDateTime(MonReaderCommande.GetOrdinal("DateCommande")));
                    mesCommandes.Add(nouvelleCommande);
                }
                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            return mesCommandes;
        }
    }
}
