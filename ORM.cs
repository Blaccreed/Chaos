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

        // récupérer les serveurs d'un utilisateur
        public static List<Serveur> GetServeurUser(int id_user)
        {
            List<Serveur> list = new List<Serveur>();
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT S.ID_SERVEUR, S.NOM_SERVEUR , S.NB_MAX_USER  FROM SERVEUR S, DROIT D  WHERE D.ID_SERVEUR = S.ID_SERVEUR AND D.ID_USER = @id_user";
            
            cmd.Parameters.Add("@id_user", MySqlDbType.Int32).Value = id_user;
            cmd.CommandText = req;
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while(rdr.Read())
            {
                Serveur serveur = new Serveur((int)rdr["ID_SERVEUR"], (string)rdr["NOM_SERVEUR"], (int)rdr["NB_MAX_USER"]);
                list.Add(serveur);
            }
            
            rdr.Close();
            return list;
        }


        public static List<Channel> GetChannelsServeur(int id_serveur)
        {
            List<Channel> list = new List<Channel>();
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT C.ID_CHANNEL, C.ID_SERVEUR, C.NOM_CHANNEL FROM CHANNEl C, SERVEUR S WHERE C.ID_SERVEUR = S.ID_SERVEUR AND C.ID_SERVEUR= @id_serveur";
            
            cmd.Parameters.Add("@id_serveur", MySqlDbType.Int32).Value = id_serveur;
            cmd.CommandText = req;
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                Channel channel = new Channel((int)rdr["ID_CHANNEL"], (int)rdr["ID_SERVEUR"], (string)rdr["NOM_CHANNEL"]);
                list.Add(channel);
            }
            
            rdr.Close();
            return list;
        }


        //récupérer les messages d'un channel

        public static List<Message> GetMessagesChannel(int id_channel)
        {
            List<Message> list = new List<Message>();
            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT M.ID_MESSAGE, M.ID_USER, M.ID_CHANNEL, M.CONTENUE, M.DT_HR_ENVOIE, U.USER FROM USER U, MESSAGE M WHERE U.ID_USER = M.ID_USER AND M.ID_CHANNEL = @id_channel";

            cmd.Parameters.Add("@id_channel", MySqlDbType.Int32).Value = id_channel;
            cmd.CommandText = req;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Message message = new Message((int)rdr["ID_MESSAGE"], (int)rdr["ID_USER"], (int)rdr["ID_CHANNEL"], (string)rdr["CONTENUE"], (DateTime)rdr["DT_HR_ENVOIE"], (string)rdr["USER"]);
                list.Add(message);
            }

            rdr.Close();
            return list;
        }

        public static void ajouterMessage(string message)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string requete = "INSERT INTO USER(ID_USER, USER, EMAIL_USER, MDP_USER) VALUES(null, @user, @email, @mdp)";
            cmd.CommandText = requete;
            cmd.Parameters.Add("null", MySqlDbType.Int32).Value = null;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = mdp;
        }




    }
}


