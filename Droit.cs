using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    class Droit
    {
        /// <summary>
        /// La classe permet de définir le droit d'accès à un serveur pour un utilisateur.
        /// </summary>
        private User user_droit;
        private Serveur serveur_droit;

        public Droit(User user_droit, Serveur serveur_droit)
        {
            this.user_droit = user_droit;
            this.serveur_droit = serveur_droit;
        }

        public User GetUserDroit()
        {
            return user_droit;
        }
        public Serveur GetServeurDroit()
        {
            return serveur_droit;
        }
    }

    
}
