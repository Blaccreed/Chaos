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
            string sConnexion = @"server = localhost;userid=root;password=root;database=chaos";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }

        public static bool Deconnexion()
        {
            conn.Close();
            return conn.State == System.Data.ConnectionState.Closed;
        }
        
        public static bool Identification(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string requete = "SELECT COUNT(*) as NbLigne FROM USER WHERE USER='" + user + "'AND MDP_USER ='" + mdp +"'";
            cmd.CommandText = requete;
            int nbLigne = Convert.ToInt32(cmd.ExecuteScalar());
            
            return (nbLigne==1);
        } 

        public static int Inscription(string user, string email, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            MySqlCommand cmd2 = conn.CreateCommand();
            string requete2 = "SELECT COUNT(*) as Existe FROM USER WHERE USER ='" + user + "'OR EMAIL_USER ='" + email + "'";
            cmd2.CommandText = requete2;
            int existe = Convert.ToInt32(cmd2.ExecuteScalar());
            if(existe == 1)
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
        

        
        
        

        



    }
}


