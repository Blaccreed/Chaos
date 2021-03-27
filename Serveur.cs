using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    class Serveur
    {
        private int id_serveur;
        private string nom_serveur;
        private int nb_user;
        private int nb_max_user;
        private string img_serveur;
        private List<User> LesUtilisateurs;
        private User LeCreateur;

        public Serveur(int id_serveur, string nom_serveur,  int nb_max_user, private string img_server)
        {
            this.id_serveur = id_serveur;
            this.nom_serveur = nom_serveur;
            this.nb_user = 0;
            this.nb_max_user = nb_max_user;
            this.LesUtilisateurs = new List<User>(User LeCreateur);

        }

        
    }
}
