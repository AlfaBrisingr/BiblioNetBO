﻿using BiblioNet.Classes;
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
    class M_Quantite
    {
        public static DataTable getQuantitebyCommande(int NoCommande)
        {
            var ds = new DataSet();
            var dt = new DataTable("Quantite");
            try
            {
                bdd.GestBiblioNetConn.Open();

                var sql = "SELECT Livre.Nom as 'Nom du Livre', Quantite.Quantite as 'Quantite', Livre.Tarif as 'Prix unitaire', (Livre.Tarif * Quantite.Quantite) as 'Montant HT (en euros)' FROM Quantite INNER JOIN Livre ON Livre.NumLivre = Quantite.NoLivres WHERE NumCommande = ?";

                var da = new MySqlDataAdapter(sql, bdd.GestBiblioNetConn);
                da.SelectCommand.Parameters.AddWithValue("@param", NoCommande);
                da.Fill(ds, "Quantite");
                dt = ds.Tables["Quantite"];
                if (dt.Rows.Count == 0)
                    throw new Exception("Aucun article ! ");
                bdd.GestBiblioNetConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                bdd.GestBiblioNetConn.Close();
            }

            return dt;
        }
       
    }
}
