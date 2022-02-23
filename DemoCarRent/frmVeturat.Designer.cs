
namespace DemoCarRent
{
    partial class frmVeturat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeturat));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLloji = new System.Windows.Forms.Label();
            this.lblModeli = new System.Windows.Forms.Label();
            this.lblRegjistrimi = new System.Windows.Forms.Label();
            this.lblViti_Prodhimit = new System.Windows.Forms.Label();
            this.lblKilomterazha = new System.Windows.Forms.Label();
            this.lblDisponueshmeria = new System.Windows.Forms.Label();
            this.lblCmimi = new System.Windows.Forms.Label();
            this.txtVetura_Id = new System.Windows.Forms.TextBox();
            this.txtViti_Prodhimit = new System.Windows.Forms.TextBox();
            this.txtCmimi = new System.Windows.Forms.TextBox();
            this.txtKilometrazha = new System.Windows.Forms.TextBox();
            this.txtRegjistrimi = new System.Windows.Forms.TextBox();
            this.txtLloji = new System.Windows.Forms.TextBox();
            this.txtModeli = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVeturat = new System.Windows.Forms.Label();
            this.dgvVeturat = new System.Windows.Forms.DataGridView();
            this.chbDisponueshmeria = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.veturatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeturat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veturatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblLloji
            // 
            resources.ApplyResources(this.lblLloji, "lblLloji");
            this.lblLloji.Name = "lblLloji";
            // 
            // lblModeli
            // 
            resources.ApplyResources(this.lblModeli, "lblModeli");
            this.lblModeli.Name = "lblModeli";
            // 
            // lblRegjistrimi
            // 
            resources.ApplyResources(this.lblRegjistrimi, "lblRegjistrimi");
            this.lblRegjistrimi.Name = "lblRegjistrimi";
            // 
            // lblViti_Prodhimit
            // 
            resources.ApplyResources(this.lblViti_Prodhimit, "lblViti_Prodhimit");
            this.lblViti_Prodhimit.Name = "lblViti_Prodhimit";
            // 
            // lblKilomterazha
            // 
            resources.ApplyResources(this.lblKilomterazha, "lblKilomterazha");
            this.lblKilomterazha.Name = "lblKilomterazha";
            // 
            // lblDisponueshmeria
            // 
            resources.ApplyResources(this.lblDisponueshmeria, "lblDisponueshmeria");
            this.lblDisponueshmeria.Name = "lblDisponueshmeria";
            // 
            // lblCmimi
            // 
            resources.ApplyResources(this.lblCmimi, "lblCmimi");
            this.lblCmimi.Name = "lblCmimi";
            // 
            // txtVetura_Id
            // 
            resources.ApplyResources(this.txtVetura_Id, "txtVetura_Id");
            this.txtVetura_Id.Name = "txtVetura_Id";
            // 
            // txtViti_Prodhimit
            // 
            resources.ApplyResources(this.txtViti_Prodhimit, "txtViti_Prodhimit");
            this.txtViti_Prodhimit.Name = "txtViti_Prodhimit";
            // 
            // txtCmimi
            // 
            resources.ApplyResources(this.txtCmimi, "txtCmimi");
            this.txtCmimi.Name = "txtCmimi";
            // 
            // txtKilometrazha
            // 
            resources.ApplyResources(this.txtKilometrazha, "txtKilometrazha");
            this.txtKilometrazha.Name = "txtKilometrazha";
            // 
            // txtRegjistrimi
            // 
            resources.ApplyResources(this.txtRegjistrimi, "txtRegjistrimi");
            this.txtRegjistrimi.Name = "txtRegjistrimi";
            // 
            // txtLloji
            // 
            resources.ApplyResources(this.txtLloji, "txtLloji");
            this.txtLloji.Name = "txtLloji";
            // 
            // txtModeli
            // 
            resources.ApplyResources(this.txtModeli, "txtModeli");
            this.txtModeli.Name = "txtModeli";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblVeturat);
            this.panel1.Name = "panel1";
            // 
            // lblVeturat
            // 
            resources.ApplyResources(this.lblVeturat, "lblVeturat");
            this.lblVeturat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVeturat.Name = "lblVeturat";
            // 
            // dgvVeturat
            // 
            resources.ApplyResources(this.dgvVeturat, "dgvVeturat");
            this.dgvVeturat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeturat.Name = "dgvVeturat";
            this.dgvVeturat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeturat_CellContentClick);
            // 
            // chbDisponueshmeria
            // 
            resources.ApplyResources(this.chbDisponueshmeria, "chbDisponueshmeria");
            this.chbDisponueshmeria.Name = "chbDisponueshmeria";
            this.chbDisponueshmeria.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // veturatBindingSource
            // 
            this.veturatBindingSource.DataMember = "Veturat";
            // 
            // frmVeturat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chbDisponueshmeria);
            this.Controls.Add(this.dgvVeturat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtModeli);
            this.Controls.Add(this.txtLloji);
            this.Controls.Add(this.txtRegjistrimi);
            this.Controls.Add(this.txtKilometrazha);
            this.Controls.Add(this.txtCmimi);
            this.Controls.Add(this.txtViti_Prodhimit);
            this.Controls.Add(this.txtVetura_Id);
            this.Controls.Add(this.lblCmimi);
            this.Controls.Add(this.lblDisponueshmeria);
            this.Controls.Add(this.lblKilomterazha);
            this.Controls.Add(this.lblViti_Prodhimit);
            this.Controls.Add(this.lblRegjistrimi);
            this.Controls.Add(this.lblModeli);
            this.Controls.Add(this.lblLloji);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmVeturat";
            this.Load += new System.EventHandler(this.frmVeturat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeturat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veturatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLloji;
        private System.Windows.Forms.Label lblModeli;
        private System.Windows.Forms.Label lblRegjistrimi;
        private System.Windows.Forms.Label lblViti_Prodhimit;
        private System.Windows.Forms.Label lblKilomterazha;
        private System.Windows.Forms.Label lblDisponueshmeria;
        private System.Windows.Forms.Label lblCmimi;
        private System.Windows.Forms.TextBox txtVetura_Id;
        private System.Windows.Forms.TextBox txtViti_Prodhimit;
        private System.Windows.Forms.TextBox txtCmimi;
        private System.Windows.Forms.TextBox txtKilometrazha;
        private System.Windows.Forms.TextBox txtRegjistrimi;
        private System.Windows.Forms.TextBox txtLloji;
        private System.Windows.Forms.TextBox txtModeli;
        private System.Windows.Forms.BindingSource veturatBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVeturat;
        private System.Windows.Forms.DataGridView dgvVeturat;
        private System.Windows.Forms.CheckBox chbDisponueshmeria;
        private System.Windows.Forms.Button btnClear;
    }
}