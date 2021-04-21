using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaos
{
    public partial class Identification : Form
    {
        public Identification()
        {
            InitializeComponent();
            if(ORM.Connexion())
            {
                lbConnServeur.Text = "On";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDeconnServeur_Click(object sender, EventArgs e)
        {
            if(ORM.Deconnexion())
            {
                lbConnServeur.Text = "Off";
            }
        }

        private void btSeConnecter_Click(object sender, EventArgs e)
        {
            if (ORM.Identification(tbUsername.Text,tbMDP.Text))
            {
                MessageBox.Show("Re-bonjour sur chaos !");
                Form f = new Chaos();
                f.Show();
                this.Hide();
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
