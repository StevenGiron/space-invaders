namespace SpaceInvaders
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.pbarSalud = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 912);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Score: ";
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntuación.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntuación.Location = new System.Drawing.Point(162, 912);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(27, 26);
            this.lblPuntuación.TabIndex = 22;
            this.lblPuntuación.Text = "0";
            // 
            // pbarSalud
            // 
            this.pbarSalud.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbarSalud.Location = new System.Drawing.Point(936, 912);
            this.pbarSalud.Name = "pbarSalud";
            this.pbarSalud.Size = new System.Drawing.Size(165, 23);
            this.pbarSalud.TabIndex = 23;
            this.pbarSalud.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(869, 909);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "HP";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1151, 961);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbarSalud);
            this.Controls.Add(this.lblPuntuación);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1167, 1000);
            this.MinimumSize = new System.Drawing.Size(1167, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label lblPuntuación;
        private ProgressBar pbarSalud;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}