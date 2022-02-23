
namespace DemoCarRent
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Register = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmaili = new System.Windows.Forms.TextBox();
            this.txtPasswordi = new System.Windows.Forms.TextBox();
            this.lblPasswordi = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Register);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.lblPassword);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            resources.ApplyResources(this.Register, "Register");
            this.Register.Controls.Add(this.btnRegister);
            this.Register.Controls.Add(this.txtName);
            this.Register.Controls.Add(this.txtMbiemri);
            this.Register.Controls.Add(this.txtEmaili);
            this.Register.Controls.Add(this.txtPasswordi);
            this.Register.Controls.Add(this.lblPasswordi);
            this.Register.Controls.Add(this.lbl);
            this.Register.Controls.Add(this.lblMbiemri);
            this.Register.Controls.Add(this.lblName);
            this.Register.Name = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtMbiemri
            // 
            resources.ApplyResources(this.txtMbiemri, "txtMbiemri");
            this.txtMbiemri.Name = "txtMbiemri";
            // 
            // txtEmaili
            // 
            resources.ApplyResources(this.txtEmaili, "txtEmaili");
            this.txtEmaili.Name = "txtEmaili";
            // 
            // txtPasswordi
            // 
            resources.ApplyResources(this.txtPasswordi, "txtPasswordi");
            this.txtPasswordi.Name = "txtPasswordi";
            // 
            // lblPasswordi
            // 
            resources.ApplyResources(this.lblPasswordi, "lblPasswordi");
            this.lblPasswordi.Name = "lblPasswordi";
            // 
            // lbl
            // 
            resources.ApplyResources(this.lbl, "lbl");
            this.lbl.Name = "lbl";
            // 
            // lblMbiemri
            // 
            resources.ApplyResources(this.lblMbiemri, "lblMbiemri");
            this.lblMbiemri.Name = "lblMbiemri";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLogin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.TextBox txtEmaili;
        private System.Windows.Forms.TextBox txtPasswordi;
        private System.Windows.Forms.Label lblPasswordi;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}