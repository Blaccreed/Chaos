using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Chaos
{
    
    public partial class Authentification : Form
    {
        Dashboard dashboard;
        public Authentification()
        {
            InitializeComponent();
            if(ORM.Connexion())
            {
                lbConnServeur.Text = "Connecté";
            }
            else
            {
                lbConnServeur.Text = "Déconnecté";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSeConnecter_Click(object sender, EventArgs e)
        {
            if (ORM.Existe(tbUsername.Text,tbMDP.Text) == 1)
            {
                dashboard = new Dashboard();
                dashboard.user = tbUsername.Text;
                dashboard.mdp = tbMDP.Text;
                MessageBox.Show(tbUsername.Text);
                
                dashboard.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("soucis");
            }
             
        }

        private void lbUser_Click(object sender, EventArgs e)
        {
            
        }

        private void tbMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSInscrire_Click(object sender, EventArgs e)
        {
            Form f = new Inscription();
            f.Show();
            this.Hide();
        }
    }
}
