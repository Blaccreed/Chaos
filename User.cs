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
        private string email_user;
        private string mdp_user;
        private string nom;
        private string prenom;
        private string tel_user;

        public User(int id_user, string email_user, string mdp_user, string tel_user)
        {
            this.id_user = id_user;
            this.email_user = email_user;
            this.mdp_user = mdp_user;
            this.tel_user = tel_user;  
        }


    }
}
