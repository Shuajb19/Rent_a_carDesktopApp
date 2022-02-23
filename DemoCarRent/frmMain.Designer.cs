
namespace DemoCarRent
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnVeturat = new System.Windows.Forms.Button();
            this.btnKlientat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAL = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.lblRent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKthimet = new System.Windows.Forms.Button();
            this.btnHuazimet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeturat
            // 
            resources.ApplyResources(this.btnVeturat, "btnVeturat");
            this.btnVeturat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVeturat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeturat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVeturat.Name = "btnVeturat";
            this.btnVeturat.UseVisualStyleBackColor = false;
            this.btnVeturat.Click += new System.EventHandler(this.btnVeturat_Click);
            // 
            // btnKlientat
            // 
            resources.ApplyResources(this.btnKlientat, "btnKlientat");
            this.btnKlientat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKlientat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKlientat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKlientat.FlatAppearance.BorderSize = 0;
            this.btnKlientat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKlientat.Name = "btnKlientat";
            this.btnKlientat.UseVisualStyleBackColor = false;
            this.btnKlientat.Click += new System.EventHandler(this.btnKlientat_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAL);
            this.panel1.Controls.Add(this.btnEN);
            this.panel1.Controls.Add(this.lblRent);
            this.panel1.Name = "panel1";
            // 
            // btnAL
            // 
            resources.ApplyResources(this.btnAL, "btnAL");
            this.btnAL.Name = "btnAL";
            this.btnAL.UseVisualStyleBackColor = true;
            this.btnAL.Click += new System.EventHandler(this.btnAL_Click);
            // 
            // btnEN
            // 
            resources.ApplyResources(this.btnEN, "btnEN");
            this.btnEN.Name = "btnEN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // lblRent
            // 
            resources.ApplyResources(this.lblRent, "lblRent");
            this.lblRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRent.Name = "lblRent";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnKthimet
            // 
            resources.ApplyResources(this.btnKthimet, "btnKthimet");
            this.btnKthimet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKthimet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKthimet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKthimet.FlatAppearance.BorderSize = 0;
            this.btnKthimet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKthimet.Name = "btnKthimet";
            this.btnKthimet.UseVisualStyleBackColor = false;
            this.btnKthimet.Click += new System.EventHandler(this.btnKthimet_Click);
            // 
            // btnHuazimet
            // 
            resources.ApplyResources(this.btnHuazimet, "btnHuazimet");
            this.btnHuazimet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuazimet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuazimet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuazimet.FlatAppearance.BorderSize = 0;
            this.btnHuazimet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuazimet.Name = "btnHuazimet";
            this.btnHuazimet.UseVisualStyleBackColor = false;
            this.btnHuazimet.Click += new System.EventHandler(this.btnHuazimet_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnHuazimet);
            this.Controls.Add(this.btnKthimet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKlientat);
            this.Controls.Add(this.btnVeturat);
            this.Name = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVeturat;
        private System.Windows.Forms.Button btnKlientat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKthimet;
        private System.Windows.Forms.Button btnHuazimet;
        private System.Windows.Forms.Button btnAL;
        private System.Windows.Forms.Button btnEN;
    }
}