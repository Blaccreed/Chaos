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
    public partial class Inscription : Form
    {
        
        public Inscription()
        {
            InitializeComponent();
            if(ORM.Connexion())
            {
                lbConn.Text = "On";
            }
            else
            {
                lbConn.Text = "Off";
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDejaCompte_Click(object sender, EventArgs e)
        {
            Form f = new Identification();
            f.Show();
            this.Hide();
        }

        private void btValider_Click_1(object sender, EventArgs e)
        {
            if(ORM.Inscription(tbUser.Text,tbEmail.Text,tbMDP.Text) == 0)
            {
                MessageBox.Show("Le compte a bien été enregistré");

            }
            else
            {

                Form f = new Identification();
                this.Hide();
                f.Show();
                
            }
        }
    }
}
