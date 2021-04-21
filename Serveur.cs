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
        private int nb_max_user;
        private string img_serveur;
        private List<User> LesUtilisateurs = new List<User>();
       

        public Serveur(int id_serveur, string nom_serveur, int nb_max_user, string img_serveur, User proprietaire)
        {
            this.id_serveur = id_serveur;
            this.nom_serveur = nom_serveur;
            this.nb_max_user = nb_max_user;
            this.img_serveur = img_serveur;
            this.LesUtilisateurs = new List<User>();
            t
            
        }
        public Serveur
        public int GetId_serveur()
        {
            return id_serveur;
        }

        public string GetNom_serveur()
        {
            return nom_serveur;
        }

        public int GetNb_max_user()
        {
            return nb_max_user;
        }

        public string GetImg_serveur()
        {
            return img_serveur;
        }

        public List<User> GetLesUtilisateurs()
        {
            return LesUtilisateurs;
        }
        
    }

        
    
}
