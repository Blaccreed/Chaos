using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chaos
{
    public partial class Dashboard : Form
    {
        
        public string user;
        public string mdp;
        
        public Dashboard()
        {
           InitializeComponent();
           
        }

        private void panelServors_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btNewServeur_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (ORM.Connexion())
            {
                lbOnOff.Text = "Connecté";

                lbPseudo.Text = user;
                User userRecup = new User(ORM.GetIdUser(lbPseudo.Text), lbPseudo.Text, ORM.GetEmailUser(lbPseudo.Text), mdp);
                List<Serveur> listeServeur = ORM.GetServeurUser(userRecup.GetId_user());
                lbId.Text = Convert.ToString(ORM.GetIdUser(lbPseudo.Text));

                ListBServeurs.Items.AddRange(listeServeur.ToArray());
            }
            else
            {
                lbOnOff.Text = "Déconnecté";
            }
              
        }

        private void ListBServeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Serveur serveur = (Serveur)ListBServeurs.SelectedItem;
            
            List<Channel> listeChannel = ORM.GetChannelsServeur(serveur.GetId_serveur());
            ListBChannel.Items.Clear();
            ListBChannel.Items.AddRange(listeChannel.ToArray());
        }

        private void ListBChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Channel channel = (Channel)ListBChannel.SelectedItem;
            List<Message> listeMessage = ORM.GetMessagesChannel(channel.GetIdChannel());
            ListBMessages.Items.Clear();
            ListBMessages.Items.AddRange(listeMessage.ToArray());
        }


        private void ListBMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Message message = (Message)ListBMessages.SelectedItem;
            MessageBox.Show(Convert.ToString(message.GetId_User()));
        }


        private void btEnvMsg_Click(object sender, EventArgs e)
        {
            Channel channel = (Channel)ListBChannel.SelectedItem;
            Message message = new Message(ORM.GetIdUser(lbPseudo.Text), channel.GetIdChannel(), tbContenue.Text, DateTime.Now);
            ORM.ajouterMessage(message);
            ListBMessages.Items.Clear();
            ListBMessages.Items.Add(message.ToString());
        }
    }
}
