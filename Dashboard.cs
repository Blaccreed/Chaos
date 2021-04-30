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
           if(ORM.Connexion())
            {
                lbOnOff.Text = "On";
            }
            else
            {
                lbOnOff.Text = "Off";
            }

            User user1 = new User(ORM.GetIdUser(Convert.ToString(lbPseudo.Text)), lbPseudo.Text, ORM.GetEmailUser(lbPseudo.Text), mdp);
            List<Serveur> listeServeur = ORM.GetServeurUser(user1.GetId_user());
            lbId.Text = Convert.ToString(ORM.GetIdUser(lbPseudo.Text));
            ListBServeurs.Items.AddRange(listeServeur.ToArray());
        }

        private void panelServors_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btNewServeur_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbPseudo.Text = user;
            

        }

        private void ListBServeurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
