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

        private static List<Serveur> GetLesServeurs(User u)
        {
            List<Serveur> serveursUser = new List<Serveur>();
            MySqlCommand cmd = conn.CreateCommand();
            string requete = "SELECT(*) FROM DROIT WHERE ID_USER=" + u.GetId_user() + "'";
            cmd.CommandText = requete;
            serveursUser.;
            return ;

        }
    }
}
