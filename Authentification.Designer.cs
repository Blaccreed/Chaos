
namespace Chaos
{
    partial class Authentification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConnServeur = new System.Windows.Forms.Label();
            this.lbStatutServeur = new System.Windows.Forms.Label();
            this.gBSeConnecter = new System.Windows.Forms.GroupBox();
            this.btSInscrire = new System.Windows.Forms.Button();
            this.btSeConnecter = new System.Windows.Forms.Button();
            this.gBSeConnecter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(49, 87);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(312, 43);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMDP.Location = new System.Drawing.Point(49, 171);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(312, 43);
            this.tbMDP.TabIndex = 1;
            this.tbMDP.UseSystemPasswordChar = true;
            this.tbMDP.TextChanged += new System.EventHandler(this.tbMDP_TextChanged);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(49, 64);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(116, 20);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Nom Utilisateur:";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mot de passe:";
            // 
            // lbConnServeur
            // 
            this.lbConnServeur.AutoSize = true;
            this.lbConnServeur.Location = new System.Drawing.Point(1072, 634);
            this.lbConnServeur.Name = "lbConnServeur";
            this.lbConnServeur.Size = new System.Drawing.Size(0, 20);
            this.lbConnServeur.TabIndex = 5;
            // 
            // lbStatutServeur
            // 
            this.lbStatutServeur.AutoSize = true;
            this.lbStatutServeur.Location = new System.Drawing.Point(962, 634);
            this.lbStatutServeur.Name = "lbStatutServeur";
            this.lbStatutServeur.Size = new System.Drawing.Size(104, 20);
            this.lbStatutServeur.TabIndex = 6;
            this.lbStatutServeur.Text = "Statut Serveur:";
            // 
            // gBSeConnecter
            // 
            this.gBSeConnecter.BackColor = System.Drawing.Color.Gray;
            this.gBSeConnecter.Controls.Add(this.btSInscrire);
            this.gBSeConnecter.Controls.Add(this.tbUsername);
            this.gBSeConnecter.Controls.Add(this.btSeConnecter);
            this.gBSeConnecter.Controls.Add(this.lbUser);
            this.gBSeConnecter.Controls.Add(this.tbMDP);
            this.gBSeConnecter.Controls.Add(this.label1);
            this.gBSeConnecter.Location = new System.Drawing.Point(329, 154);
            this.gBSeConnecter.Name = "gBSeConnecter";
            this.gBSeConnecter.Size = new System.Drawing.Size(441, 388);
            this.gBSeConnecter.TabIndex = 8;
            this.gBSeConnecter.TabStop = false;
            this.gBSeConnecter.Text = "Se Connecter";
            // 
            // btSInscrire
            // 
            this.btSInscrire.Location = new System.Drawing.Point(49, 302);
            this.btSInscrire.Name = "btSInscrire";
            this.btSInscrire.Size = new System.Drawing.Size(312, 44);
            this.btSInscrire.TabIndex = 10;
            this.btSInscrire.Text = "S\'incrire";
            this.btSInscrire.UseVisualStyleBackColor = true;
            this.btSInscrire.Click += new System.EventHandler(this.btSInscrire_Click);
            // 
            // btSeConnecter
            // 
            this.btSeConnecter.Location = new System.Drawing.Point(49, 233);
            this.btSeConnecter.Name = "btSeConnecter";
            this.btSeConnecter.Size = new System.Drawing.Size(312, 44);
            this.btSeConnecter.TabIndex = 9;
            this.btSeConnecter.Text = "Se Connecter";
            this.btSeConnecter.UseVisualStyleBackColor = true;
            this.btSeConnecter.Click += new System.EventHandler(this.btSeConnecter_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1155, 668);
            this.Controls.Add(this.gBSeConnecter);
            this.Controls.Add(this.lbStatutServeur);
            this.Controls.Add(this.lbConnServeur);
            this.Name = "Authentification";
            this.Text = "Chaos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBSeConnecter.ResumeLayout(false);
            this.gBSeConnecter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbConnServeur;
        private System.Windows.Forms.Label lbStatutServeur;
        private System.Windows.Forms.GroupBox gBSeConnecter;
        private System.Windows.Forms.Button btSeConnecter;
        private System.Windows.Forms.Button btSInscrire;
    }
}

