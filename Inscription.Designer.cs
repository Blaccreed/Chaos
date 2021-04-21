
namespace Chaos
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDejaCompte = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lbMDP = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMDP.Location = new System.Drawing.Point(18, 228);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(335, 38);
            this.tbMDP.TabIndex = 0;
            this.tbMDP.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(18, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(335, 38);
            this.tbEmail.TabIndex = 1;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.Location = new System.Drawing.Point(18, 145);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(335, 38);
            this.tbUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Créer un compte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDejaCompte);
            this.groupBox1.Controls.Add(this.btValider);
            this.groupBox1.Controls.Add(this.lbMDP);
            this.groupBox1.Controls.Add(this.lbUser);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.tbMDP);
            this.groupBox1.Location = new System.Drawing.Point(219, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btDejaCompte
            // 
            this.btDejaCompte.Location = new System.Drawing.Point(109, 343);
            this.btDejaCompte.Name = "btDejaCompte";
            this.btDejaCompte.Size = new System.Drawing.Size(132, 47);
            this.btDejaCompte.TabIndex = 7;
            this.btDejaCompte.Text = "Déjà un compte";
            this.btDejaCompte.UseVisualStyleBackColor = true;
            this.btDejaCompte.Click += new System.EventHandler(this.btDejaCompte_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(109, 272);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(132, 51);
            this.btValider.TabIndex = 6;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click_1);
            // 
            // lbMDP
            // 
            this.lbMDP.AutoSize = true;
            this.lbMDP.Location = new System.Drawing.Point(18, 205);
            this.lbMDP.Name = "lbMDP";
            this.lbMDP.Size = new System.Drawing.Size(108, 20);
            this.lbMDP.TabIndex = 5;
            this.lbMDP.Text = "MOT DE PASSE";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(18, 122);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(147, 20);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "NOM D\'UTILISATEUR";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(18, 42);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 20);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "E-MAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Statut connexion:";
            // 
            // lbConn
            // 
            this.lbConn.AutoSize = true;
            this.lbConn.Location = new System.Drawing.Point(821, 509);
            this.lbConn.Name = "lbConn";
            this.lbConn.Size = new System.Drawing.Size(56, 20);
            this.lbConn.TabIndex = 6;
            this.lbConn.Text = "lbConn";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 538);
            this.Controls.Add(this.lbConn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lbMDP;
        private System.Windows.Forms.Button btDejaCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConn;
    }
}