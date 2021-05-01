using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    public class Serveur
    {
        private int id_serveur;
        private string nom_serveur;
        private int nb_max_user;
        
        private List<User> LesUtilisateurs = new List<User>();
       

        public Serveur(int id_serveur, string nom_serveur, int nb_max_user)
        {
            this.id_serveur = id_serveur;
            this.nom_serveur = nom_serveur;
            this.nb_max_user = nb_max_user;
            this.LesUtilisateurs = new List<User>();
            
        }
        
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

        

        public List<User> GetLesUtilisateurs()
        {
            return LesUtilisateurs;
        }

        public void NomServeur(string nom_serveur)
        {
            this.nom_serveur = nom_serveur;
        }

        public override string ToString()
        {
            return "ID_SERVEUR:" + "  " + id_serveur +"- NOM_SERVEUR:" + nom_serveur;
        }
    }

        
    
}
