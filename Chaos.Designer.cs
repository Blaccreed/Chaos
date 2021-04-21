
namespace Chaos
{
    partial class Chaos
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelServors = new System.Windows.Forms.Panel();
            this.panelServors.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer un Serveur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelServors
            // 
            this.panelServors.BackColor = System.Drawing.Color.Gray;
            this.panelServors.Controls.Add(this.button1);
            this.panelServors.Location = new System.Drawing.Point(-2, -1);
            this.panelServors.Name = "panelServors";
            this.panelServors.Size = new System.Drawing.Size(222, 650);
            this.panelServors.TabIndex = 1;
            this.panelServors.Paint += new System.Windows.Forms.PaintEventHandler(this.panelServors_Paint);
            // 
            // Chaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1039, 647);
            this.Controls.Add(this.panelServors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chaos";
            this.Text = "Chaos";
            this.panelServors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelServors;
    }
}