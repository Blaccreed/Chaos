
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
            this.panelServors = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.ListBServeurs = new System.Windows.Forms.ListBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatutCo = new System.Windows.Forms.Label();
            this.lbOnOff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBChannel = new System.Windows.Forms.ListBox();
            this.panelServors.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServors
            // 
            this.panelServors.BackColor = System.Drawing.Color.DimGray;
            this.panelServors.Controls.Add(this.lbId);
            this.panelServors.Controls.Add(this.ListBServeurs);
            this.panelServors.Controls.Add(this.lbPseudo);
            this.panelServors.Controls.Add(this.label2);
            this.panelServors.Location = new System.Drawing.Point(-2, -1);
            this.panelServors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelServors.Name = "panelServors";
            this.panelServors.Size = new System.Drawing.Size(336, 567);
            this.panelServors.TabIndex = 1;
            this.panelServors.Paint += new System.Windows.Forms.PaintEventHandler(this.panelServors_Paint);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(126, 544);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 15);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "ID";
            // 
            // ListBServeurs
            // 
            this.ListBServeurs.BackColor = System.Drawing.Color.White;
            this.ListBServeurs.FormattingEnabled = true;
            this.ListBServeurs.ItemHeight = 15;
            this.ListBServeurs.Location = new System.Drawing.Point(12, 20);
            this.ListBServeurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBServeurs.Name = "ListBServeurs";
            this.ListBServeurs.Size = new System.Drawing.Size(283, 514);
            this.ListBServeurs.TabIndex = 7;
            this.ListBServeurs.SelectedIndexChanged += new System.EventHandler(this.ListBServeurs_SelectedIndexChanged);
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(70, 544);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(46, 15);
            this.lbPseudo.TabIndex = 3;
            this.lbPseudo.Text = "pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pseudo:";
            // 
            // lbStatutCo
            // 
            this.lbStatutCo.AutoSize = true;
            this.lbStatutCo.Location = new System.Drawing.Point(1091, 544);
            this.lbStatutCo.Name = "lbStatutCo";
            this.lbStatutCo.Size = new System.Drawing.Size(41, 15);
            this.lbStatutCo.TabIndex = 5;
            this.lbStatutCo.Text = "Statut:";
            // 
            // lbOnOff
            // 
            this.lbOnOff.AutoSize = true;
            this.lbOnOff.Location = new System.Drawing.Point(1141, 544);
            this.lbOnOff.Name = "lbOnOff";
            this.lbOnOff.Size = new System.Drawing.Size(24, 15);
            this.lbOnOff.TabIndex = 6;
            this.lbOnOff.Text = "Off";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.ListBChannel);
            this.panel1.Location = new System.Drawing.Point(329, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 567);
            this.panel1.TabIndex = 7;
            // 
            // ListBChannel
            // 
            this.ListBChannel.FormattingEnabled = true;
            this.ListBChannel.ItemHeight = 15;
            this.ListBChannel.Location = new System.Drawing.Point(10, 34);
            this.ListBChannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBChannel.Name = "ListBChannel";
            this.ListBChannel.Size = new System.Drawing.Size(96, 484);
            this.ListBChannel.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1229, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbOnOff);
            this.Controls.Add(this.lbStatutCo);
            this.Controls.Add(this.panelServors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Chaos";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelServors.ResumeLayout(false);
            this.panelServors.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelServors;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatutCo;
        private System.Windows.Forms.Label lbOnOff;
        private System.Windows.Forms.ListBox ListBServeurs;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBChannel;
    }
}