
namespace DemoCarRent
{
    partial class frmHuazimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuazimet));
            this.lblHuazimi_Id = new System.Windows.Forms.Label();
            this.lblKlient_Id = new System.Windows.Forms.Label();
            this.lblRegjVetures = new System.Windows.Forms.Label();
            this.lblData_Huazimit = new System.Windows.Forms.Label();
            this.lblCmimi = new System.Windows.Forms.Label();
            this.txtHuazimi_Id = new System.Windows.Forms.TextBox();
            this.txtPagesa = new System.Windows.Forms.TextBox();
            this.dtpData_Huazimit = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbEmri_Klientit = new System.Windows.Forms.ComboBox();
            this.cbRegjistrimi = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEmriKlientit = new System.Windows.Forms.Label();
            this.txtVetura_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHuazimet = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvHuazimet = new System.Windows.Forms.DataGridView();
            this.txtKlienti_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHuazimi_Id
            // 
            resources.ApplyResources(this.lblHuazimi_Id, "lblHuazimi_Id");
            this.lblHuazimi_Id.Name = "lblHuazimi_Id";
            // 
            // lblKlient_Id
            // 
            resources.ApplyResources(this.lblKlient_Id, "lblKlient_Id");
            this.lblKlient_Id.Name = "lblKlient_Id";
            // 
            // lblRegjVetures
            // 
            resources.ApplyResources(this.lblRegjVetures, "lblRegjVetures");
            this.lblRegjVetures.Name = "lblRegjVetures";
            // 
            // lblData_Huazimit
            // 
            resources.ApplyResources(this.lblData_Huazimit, "lblData_Huazimit");
            this.lblData_Huazimit.Name = "lblData_Huazimit";
            // 
            // lblCmimi
            // 
            resources.ApplyResources(this.lblCmimi, "lblCmimi");
            this.lblCmimi.Name = "lblCmimi";
            // 
            // txtHuazimi_Id
            // 
            resources.ApplyResources(this.txtHuazimi_Id, "txtHuazimi_Id");
            this.txtHuazimi_Id.Name = "txtHuazimi_Id";
            // 
            // txtPagesa
            // 
            resources.ApplyResources(this.txtPagesa, "txtPagesa");
            this.txtPagesa.Name = "txtPagesa";
            // 
            // dtpData_Huazimit
            // 
            resources.ApplyResources(this.dtpData_Huazimit, "dtpData_Huazimit");
            this.dtpData_Huazimit.Name = "dtpData_Huazimit";
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
            // cbEmri_Klientit
            // 
            resources.ApplyResources(this.cbEmri_Klientit, "cbEmri_Klientit");
            this.cbEmri_Klientit.FormattingEnabled = true;
            this.cbEmri_Klientit.Name = "cbEmri_Klientit";
            this.cbEmri_Klientit.SelectedIndexChanged += new System.EventHandler(this.cbEmri_Klientit_SelectedIndexChanged);
            this.cbEmri_Klientit.SelectionChangeCommitted += new System.EventHandler(this.cbKlient_Id_SelectionChangeCommitted);
            // 
            // cbRegjistrimi
            // 
            resources.ApplyResources(this.cbRegjistrimi, "cbRegjistrimi");
            this.cbRegjistrimi.FormattingEnabled = true;
            this.cbRegjistrimi.Name = "cbRegjistrimi";
            this.cbRegjistrimi.SelectedIndexChanged += new System.EventHandler(this.cbRegjistrimi_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // lblEmriKlientit
            // 
            resources.ApplyResources(this.lblEmriKlientit, "lblEmriKlientit");
            this.lblEmriKlientit.Name = "lblEmriKlientit";
            // 
            // txtVetura_Id
            // 
            resources.ApplyResources(this.txtVetura_Id, "txtVetura_Id");
            this.txtVetura_Id.Name = "txtVetura_Id";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHuazimet);
            this.panel1.Name = "panel1";
            // 
            // lblHuazimet
            // 
            resources.ApplyResources(this.lblHuazimet, "lblHuazimet");
            this.lblHuazimet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHuazimet.Name = "lblHuazimet";
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
            // dgvHuazimet
            // 
            resources.ApplyResources(this.dgvHuazimet, "dgvHuazimet");
            this.dgvHuazimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuazimet.Name = "dgvHuazimet";
            this.dgvHuazimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuazimet_CellContentClick);
            // 
            // txtKlienti_Id
            // 
            resources.ApplyResources(this.txtKlienti_Id, "txtKlienti_Id");
            this.txtKlienti_Id.Name = "txtKlienti_Id";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // frmHuazimet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKlienti_Id);
            this.Controls.Add(this.dgvHuazimet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVetura_Id);
            this.Controls.Add(this.lblEmriKlientit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbRegjistrimi);
            this.Controls.Add(this.cbEmri_Klientit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpData_Huazimit);
            this.Controls.Add(this.txtPagesa);
            this.Controls.Add(this.txtHuazimi_Id);
            this.Controls.Add(this.lblCmimi);
            this.Controls.Add(this.lblData_Huazimit);
            this.Controls.Add(this.lblRegjVetures);
            this.Controls.Add(this.lblKlient_Id);
            this.Controls.Add(this.lblHuazimi_Id);
            this.Name = "frmHuazimet";
            this.Load += new System.EventHandler(this.frmHuazimet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuazimi_Id;
        private System.Windows.Forms.Label lblKlient_Id;
        private System.Windows.Forms.Label lblRegjVetures;
        private System.Windows.Forms.Label lblData_Huazimit;
        private System.Windows.Forms.Label lblCmimi;
        private System.Windows.Forms.TextBox txtHuazimi_Id;
        private System.Windows.Forms.TextBox txtPagesa;
        private System.Windows.Forms.DateTimePicker dtpData_Huazimit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbEmri_Klientit;
        private System.Windows.Forms.ComboBox cbRegjistrimi;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmriKlientit;
        private System.Windows.Forms.TextBox txtVetura_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHuazimet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veturaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriKlientitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHuazimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiVeturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iKthyerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dgvHuazimet;
        private System.Windows.Forms.TextBox txtKlienti_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}