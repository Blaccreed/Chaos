using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    class User
    {
        private int id_user;
        private string user;
        private string email_user;
        private string mdp_user;
        private List<Serveur> serveurs = new List<Serveur>();

        public User(int id_user, string user, string email_user, string mdp_user)
        {
            this.id_user = id_user;
            this.user = user;
            this.email_user = email_user;
            this.mdp_user = mdp_user;
            this.serveurs = new List<Serveur>();
        }

        public int GetId_user()
        {
            return id_user;
        }

        public string GetEmail_user()
        {
            return email_user;
        }

        public string GetMdp_user()
        {
            return mdp_user;
        }

        public List<Serveur> GetServeurs()
        {
            return serveurs;
        }




    }
}
