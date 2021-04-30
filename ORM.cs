using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Chaos
{
    public static class ORM
    {
        private static MySqlConnection conn = null;

        public static bool Connexion()
        {
            string sConnexion = @"server=localhost;userid=root;password=root;database=chaos";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }

        public static bool Deconnexion()
        {
            conn.Close();
            return conn.State == System.Data.ConnectionState.Closed;
        }

        public static int InscriptionUser(string user, string email, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlCommand cmd2 = conn.CreateCommand();
            string requete2 = "SELECT COUNT(*) as Existe FROM USER WHERE USER ='" + user + "'OR EMAIL_USER ='" + email + "'";
            cmd2.CommandText = requete2;
            int existe = Convert.ToInt32(cmd2.ExecuteScalar());
            if (existe == 1)
            {
                MessageBox.Show("Il y'a déjà un compte qui existe avec même email ou user");

            }
            else
            {

                string requete = "INSERT INTO USER(ID_USER, USER, EMAIL_USER, MDP_USER) VALUES(null, @user, @email, @mdp)";
                cmd.CommandText = requete;
                cmd.Parameters.Add("null", MySqlDbType.Int32).Value = null;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = mdp;

            }

            return existe;
        }

        public static int Existe(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT COUNT(*) FROM USER WHERE USER = '" + user + "' AND MDP_USER = '" + mdp + "'";
            cmd.CommandText = req;
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            return c;
        }

        public static int GetIdUser(string user)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT ID_USER FROM USER WHERE USER = @user";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.CommandText = req;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id; 
        }
            
        public static string GetEmailUser(string user)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT EMAIL_USER FROM USER WHERE USER = @user";
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.CommandText = req;
            string email = Convert.ToString(cmd.ExecuteScalar());
            return email;
        }

        public static List<Serveur> GetServeurUser(int id)
        {
            List<Serveur> list = new List<Serveur>();
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT S.ID_SERVEUR, S.NOM_SERVEUR , S.NB_MAX_USER  FROM SERVEUR S, DROIT D  WHERE D.ID_SERVEUR = S.ID_SERVEUR AND D.ID_USER = @id";
            
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.CommandText = req;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Serveur serveurRecup = new Serveur((int)rdr["ID_SERVEUR"], (string)rdr["NOM_SERVEUR"], (int)rdr["NB_MAX_USER"]);
                list.Add(serveurRecup);
            }
            rdr.Close();
            return list;
        }

        public static List<Serveur> GetServeurs()
        {
            List<Serveur> list = new List<Serveur>();
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT *  FROM SERVEUR";

           
            cmd.CommandText = req;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Serveur serveurRecup = new Serveur((int)rdr["ID_SERVEUR"], (string)rdr["NOM_SERVEUR"], (int)rdr["NB_MAX_USER"]);
                list.Add(serveurRecup);
            }
            rdr.Close();
            return list;
        }










    }
}


