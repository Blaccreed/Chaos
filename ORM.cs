using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Chaos
{
    class ORM
    {
            private static MySqlConnection conn = null;

            /// <summary>
            /// Permet d'opérer une connexion entre le client applicatif et le serveur de base de données
            /// </summary>
            /// <returns>Un booléen : true si la connexion a pu s'opérer, false sinon</returns>
            public static bool Connexion()
            {
               string sConnexion = @"server=localhost;userid=root;passwords=root;database=chaos";
               conn = new MySqlConnection(sConnexion);
               conn.Open();
               return (conn.State == System.Data.ConnectionState.Open);
            }

            /// <summary>
            /// Permet de fermer une connexion entre le client applicatif et le serveur de base de données
            /// </summary>
            /// <returns>Un booléen : true si la déconnexion a pu s'opérer, false sinon</returns>
            public static bool Deconnexion()
            {
                conn.Close();
                return conn.State == System.Data.ConnectionState.Closed;
            }

            /// <summary>
            /// Accesseur de l'objet MySqlConnection
            /// </summary>
            /// <returns>La connexion au format MySqlConnection</returns>
            public static MySqlConnection GetConn()
            {
                return conn;
            }


           
        }
    }


