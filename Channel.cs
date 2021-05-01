using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos
{
    public class Channel
    {
        private int id_channel;
        private int id_serveur;
        private string nom_channel;

        public Channel(int id_channel, int id_serveur, string nom_channel)
        {
            this.id_channel = id_channel;
            this.id_serveur = id_serveur;
            this.nom_channel = nom_channel;
        }

        public int GetIdChannel()
        {
            return id_channel;
        }

        public int GetIdServeur()
        {
            return id_serveur;
        }

        public string GetNomChannel()
        {
            return nom_channel;
        }

        public override string ToString()
        {
            return "ID:" + "  " + id_channel + "- NOM:" + nom_channel;
        }
    }
}
