using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BiblioNet.Models
{
    class bdd
    {
        static public MySqlConnection GestBiblioNetConn = new MySqlConnection("server=btsinfo-rousseau53.fr;port=33017;user=2014-biblionet;password=123456;database=2014-biblionet_base");

    }
}
