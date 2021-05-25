using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    public class Message
    {
        /// <summary>
        /// Cette classe permet de gérer les messages que s'envoient les utilisateurs.
        /// </summary>
        private int id_message;
        private int id_user;
        private int id_channel;
        private string contenue;
        private DateTime dt_hr_env_msg;
        private string pseudo;

        public Message(int id_message, int id_user, int id_channel, string contenue, DateTime dt_hr_env_msg, string pseudo)
        {
            this.id_message = id_message;
            this.id_user = id_user;
            this.id_channel = id_channel;
            this.contenue = contenue;
            this.dt_hr_env_msg = dt_hr_env_msg;
            this.pseudo = pseudo;
        }

        public Message(int id_user, int id_channel, string contenue, DateTime dt_hr_env_msg)
        {
            this.id_user = id_user;
            this.id_channel = id_channel;
            this.contenue = contenue;
            this.dt_hr_env_msg = dt_hr_env_msg;
        }

        public int GetId_message()
        {
            return id_message;
        }

        public int GetId_User()
        {
            return id_message;
        }

        public int GetId_Channel()
        {
            return id_message;
        }


        public string GetContenue()
        {
            return contenue;
        }

        public DateTime GetDt_hr_env_msg()
        {
            return dt_hr_env_msg;
        }

        public string GetPseudo()
        {
            return pseudo;
        }

        

        public override string ToString()
        {
            return ">>>" + " " +pseudo + ":" + "  " + contenue + "              " + "[" + dt_hr_env_msg + "]";
        }
    }
}
