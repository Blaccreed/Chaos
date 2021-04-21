using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    class Message
    {
        /// <summary>
        /// Cette classe permet de gérer les messages que s'envoient les utilisateurs.
        /// </summary>
        private int id_message;
        private string contenue;
        private DateTime dt_hr_env_msg;
        private User LUtilisateur;
        private Channel LeChannel;

        public Message(int id_message, string contenue, DateTime dt_hr_env_msg, User LUtilisateur, Channel LeChannel)
        {
            this.id_message = id_message;
            this.contenue = contenue;
            this.dt_hr_env_msg = dt_hr_env_msg;
            this.LUtilisateur = LUtilisateur;
            this.LeChannel = LeChannel;
        }

        public int GetId_message()
        {
            return id_message;
        }

        public String GetContenue()
        {
            return contenue;
        }

        public DateTime GetDt_hr_env_msg()
        {
            return dt_hr_env_msg;
        }

        public User GetLUtilisateur()
        {
            return LUtilisateur;
        }

        public Channel GetLeChannel()
        {
            return LeChannel;
        }


    }
}
