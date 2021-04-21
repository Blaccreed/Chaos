using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Chaos
{
    public static class ORMUser
    {
        private static MySqlConnection conn = null;

        private static List<Serveur> GetLesServeursUser(User u)
        {
            List<Serveur> serveursUser = new List<Serveur>();
            
            MySqlCommand cmd = conn.CreateCommand();
            string requete = "SELECT S.ID_SERVEUR, S.NOM_SERVEUR, S.NB_MAX_USER FROM SERVEUR S, DROIT D WHERE S.ID_SERVEUR = D.ID_SERVEUR AND ID_USER = " + u.GetId_user()+"'";
            cmd.CommandText = requete;
            MySqlDataReader   rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
              
                Serveur s = new Serveur((int)rdr["ID_SERVEUR"], (string)rdr["NOM_SERVEUR"], (int)rdr["NB_MAX_USER"], (string)rdr["IMG_SERVEUR"]);
                serveursUser.Add(s);
                s.GetLesUtilisateurs().Add(u);
            }
            return serveursUser;
        }

        

    }
}
