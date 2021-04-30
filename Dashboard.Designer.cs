
namespace Chaos
{
    partial class Dashboard
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
            this.btNewServeur = new System.Windows.Forms.Button();
            this.panelServors = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.ListBServeurs = new System.Windows.Forms.ListBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatutCo = new System.Windows.Forms.Label();
            this.lbOnOff = new System.Windows.Forms.Label();
            this.panelServors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNewServeur
            // 
            this.btNewServeur.Location = new System.Drawing.Point(14, 20);
            this.btNewServeur.Name = "btNewServeur";
            this.btNewServeur.Size = new System.Drawing.Size(258, 61);
            this.btNewServeur.TabIndex = 0;
            this.btNewServeur.Text = "Créer un Serveur";
            this.btNewServeur.UseVisualStyleBackColor = true;
            this.btNewServeur.Click += new System.EventHandler(this.btNewServeur_Click);
            // 
            // panelServors
            // 
            this.panelServors.BackColor = System.Drawing.Color.Gray;
            this.panelServors.Controls.Add(this.lbId);
            this.panelServors.Controls.Add(this.ListBServeurs);
            this.panelServors.Controls.Add(this.lbPseudo);
            this.panelServors.Controls.Add(this.btNewServeur);
            this.panelServors.Controls.Add(this.label2);
            this.panelServors.Location = new System.Drawing.Point(-2, -1);
            this.panelServors.Name = "panelServors";
            this.panelServors.Size = new System.Drawing.Size(305, 650);
            this.panelServors.TabIndex = 1;
            this.panelServors.Paint += new System.Windows.Forms.PaintEventHandler(this.panelServors_Paint);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(197, 608);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 20);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "ID";
            // 
            // ListBServeurs
            // 
            this.ListBServeurs.BackColor = System.Drawing.Color.White;
            this.ListBServeurs.FormattingEnabled = true;
            this.ListBServeurs.ItemHeight = 20;
            this.ListBServeurs.Location = new System.Drawing.Point(14, 87);
            this.ListBServeurs.Name = "ListBServeurs";
            this.ListBServeurs.Size = new System.Drawing.Size(258, 504);
            this.ListBServeurs.TabIndex = 7;
            this.ListBServeurs.SelectedIndexChanged += new System.EventHandler(this.ListBServeurs_SelectedIndexChanged);
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(118, 608);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(0, 20);
            this.lbPseudo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pseudo:";
            // 
            // lbStatutCo
            // 
            this.lbStatutCo.AutoSize = true;
            this.lbStatutCo.Location = new System.Drawing.Point(922, 618);
            this.lbStatutCo.Name = "lbStatutCo";
            this.lbStatutCo.Size = new System.Drawing.Size(51, 20);
            this.lbStatutCo.TabIndex = 5;
            this.lbStatutCo.Text = "Statut:";
            // 
            // lbOnOff
            // 
            this.lbOnOff.AutoSize = true;
            this.lbOnOff.Location = new System.Drawing.Point(979, 618);
            this.lbOnOff.Name = "lbOnOff";
            this.lbOnOff.Size = new System.Drawing.Size(30, 20);
            this.lbOnOff.TabIndex = 6;
            this.lbOnOff.Text = "Off";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 647);
            this.Controls.Add(this.lbOnOff);
            this.Controls.Add(this.lbStatutCo);
            this.Controls.Add(this.panelServors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Chaos";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelServors.ResumeLayout(false);
            this.panelServors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewServeur;
        private System.Windows.Forms.Panel panelServors;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatutCo;
        private System.Windows.Forms.Label lbOnOff;
        private System.Windows.Forms.ListBox ListBServeurs;
        private System.Windows.Forms.Label lbId;
    }
}