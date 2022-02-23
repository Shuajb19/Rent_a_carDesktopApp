
namespace DemoCarRent
{
    partial class frmKthimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKthimet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblEmriKlientit = new System.Windows.Forms.Label();
            this.lblData_Dorezimit = new System.Windows.Forms.Label();
            this.lblVetura_Id = new System.Windows.Forms.Label();
            this.lblReturn_Id = new System.Windows.Forms.Label();
            this.txtEmriKlientit = new System.Windows.Forms.TextBox();
            this.dtpData_Dorezimit = new System.Windows.Forms.DateTimePicker();
            this.txtReturn_Id = new System.Windows.Forms.TextBox();
            this.lblDitetEShfrytezimit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCmimiTotal = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtVetura_Id = new System.Windows.Forms.TextBox();
            this.dtpData_Huazimit = new System.Windows.Forms.DateTimePicker();
            this.lblDataHuazimit = new System.Windows.Forms.Label();
            this.lblCmimi = new System.Windows.Forms.Label();
            this.lblDitetE_Shfrytezimit_Rezultati = new System.Windows.Forms.Label();
            this.lblCmimiVetures_Rezultati = new System.Windows.Forms.Label();
            this.lblCmimiTotal_Rezultati = new System.Windows.Forms.Label();
            this.btnKalkulo = new System.Windows.Forms.Button();
            this.txtKlienti_Id = new System.Windows.Forms.TextBox();
            this.lblKlienti_Id = new System.Windows.Forms.Label();
            this.dgvHuazimet = new System.Windows.Forms.DataGridView();
            this.dgvKthimet = new System.Windows.Forms.DataGridView();
            this.txtRent_Id = new System.Windows.Forms.TextBox();
            this.lblRent_Id = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKthimet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblRent);
            this.panel1.Name = "panel1";
            // 
            // lblRent
            // 
            resources.ApplyResources(this.lblRent, "lblRent");
            this.lblRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRent.Name = "lblRent";
            // 
            // lblEmriKlientit
            // 
            resources.ApplyResources(this.lblEmriKlientit, "lblEmriKlientit");
            this.lblEmriKlientit.Name = "lblEmriKlientit";
            // 
            // lblData_Dorezimit
            // 
            resources.ApplyResources(this.lblData_Dorezimit, "lblData_Dorezimit");
            this.lblData_Dorezimit.Name = "lblData_Dorezimit";
            // 
            // lblVetura_Id
            // 
            resources.ApplyResources(this.lblVetura_Id, "lblVetura_Id");
            this.lblVetura_Id.Name = "lblVetura_Id";
            // 
            // lblReturn_Id
            // 
            resources.ApplyResources(this.lblReturn_Id, "lblReturn_Id");
            this.lblReturn_Id.Name = "lblReturn_Id";
            // 
            // txtEmriKlientit
            // 
            resources.ApplyResources(this.txtEmriKlientit, "txtEmriKlientit");
            this.txtEmriKlientit.Name = "txtEmriKlientit";
            // 
            // dtpData_Dorezimit
            // 
            resources.ApplyResources(this.dtpData_Dorezimit, "dtpData_Dorezimit");
            this.dtpData_Dorezimit.Name = "dtpData_Dorezimit";
            // 
            // txtReturn_Id
            // 
            resources.ApplyResources(this.txtReturn_Id, "txtReturn_Id");
            this.txtReturn_Id.Name = "txtReturn_Id";
            // 
            // lblDitetEShfrytezimit
            // 
            resources.ApplyResources(this.lblDitetEShfrytezimit, "lblDitetEShfrytezimit");
            this.lblDitetEShfrytezimit.Name = "lblDitetEShfrytezimit";
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
            // lblCmimiTotal
            // 
            resources.ApplyResources(this.lblCmimiTotal, "lblCmimiTotal");
            this.lblCmimiTotal.Name = "lblCmimiTotal";
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
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtVetura_Id
            // 
            resources.ApplyResources(this.txtVetura_Id, "txtVetura_Id");
            this.txtVetura_Id.Name = "txtVetura_Id";
            // 
            // dtpData_Huazimit
            // 
            resources.ApplyResources(this.dtpData_Huazimit, "dtpData_Huazimit");
            this.dtpData_Huazimit.Name = "dtpData_Huazimit";
            // 
            // lblDataHuazimit
            // 
            resources.ApplyResources(this.lblDataHuazimit, "lblDataHuazimit");
            this.lblDataHuazimit.Name = "lblDataHuazimit";
            // 
            // lblCmimi
            // 
            resources.ApplyResources(this.lblCmimi, "lblCmimi");
            this.lblCmimi.Name = "lblCmimi";
            // 
            // lblDitetE_Shfrytezimit_Rezultati
            // 
            resources.ApplyResources(this.lblDitetE_Shfrytezimit_Rezultati, "lblDitetE_Shfrytezimit_Rezultati");
            this.lblDitetE_Shfrytezimit_Rezultati.Name = "lblDitetE_Shfrytezimit_Rezultati";
            // 
            // lblCmimiVetures_Rezultati
            // 
            resources.ApplyResources(this.lblCmimiVetures_Rezultati, "lblCmimiVetures_Rezultati");
            this.lblCmimiVetures_Rezultati.Name = "lblCmimiVetures_Rezultati";
            // 
            // lblCmimiTotal_Rezultati
            // 
            resources.ApplyResources(this.lblCmimiTotal_Rezultati, "lblCmimiTotal_Rezultati");
            this.lblCmimiTotal_Rezultati.Name = "lblCmimiTotal_Rezultati";
            // 
            // btnKalkulo
            // 
            resources.ApplyResources(this.btnKalkulo, "btnKalkulo");
            this.btnKalkulo.Name = "btnKalkulo";
            this.btnKalkulo.UseVisualStyleBackColor = true;
            this.btnKalkulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKlienti_Id
            // 
            resources.ApplyResources(this.txtKlienti_Id, "txtKlienti_Id");
            this.txtKlienti_Id.Name = "txtKlienti_Id";
            // 
            // lblKlienti_Id
            // 
            resources.ApplyResources(this.lblKlienti_Id, "lblKlienti_Id");
            this.lblKlienti_Id.Name = "lblKlienti_Id";
            // 
            // dgvHuazimet
            // 
            resources.ApplyResources(this.dgvHuazimet, "dgvHuazimet");
            this.dgvHuazimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuazimet.Name = "dgvHuazimet";
            this.dgvHuazimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuazimet_CellContentClick);
            // 
            // dgvKthimet
            // 
            resources.ApplyResources(this.dgvKthimet, "dgvKthimet");
            this.dgvKthimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKthimet.Name = "dgvKthimet";
            this.dgvKthimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKthimet_CellContentClick);
            // 
            // txtRent_Id
            // 
            resources.ApplyResources(this.txtRent_Id, "txtRent_Id");
            this.txtRent_Id.Name = "txtRent_Id";
            // 
            // lblRent_Id
            // 
            resources.ApplyResources(this.lblRent_Id, "lblRent_Id");
            this.lblRent_Id.Name = "lblRent_Id";
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
            // frmKthimet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRent_Id);
            this.Controls.Add(this.txtRent_Id);
            this.Controls.Add(this.dgvKthimet);
            this.Controls.Add(this.dgvHuazimet);
            this.Controls.Add(this.lblKlienti_Id);
            this.Controls.Add(this.txtKlienti_Id);
            this.Controls.Add(this.btnKalkulo);
            this.Controls.Add(this.lblCmimiTotal_Rezultati);
            this.Controls.Add(this.lblCmimiVetures_Rezultati);
            this.Controls.Add(this.lblDitetE_Shfrytezimit_Rezultati);
            this.Controls.Add(this.lblCmimi);
            this.Controls.Add(this.lblDataHuazimit);
            this.Controls.Add(this.dtpData_Huazimit);
            this.Controls.Add(this.txtVetura_Id);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCmimiTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDitetEShfrytezimit);
            this.Controls.Add(this.txtEmriKlientit);
            this.Controls.Add(this.dtpData_Dorezimit);
            this.Controls.Add(this.txtReturn_Id);
            this.Controls.Add(this.lblEmriKlientit);
            this.Controls.Add(this.lblData_Dorezimit);
            this.Controls.Add(this.lblVetura_Id);
            this.Controls.Add(this.lblReturn_Id);
            this.Controls.Add(this.panel1);
            this.Name = "frmKthimet";
            this.Load += new System.EventHandler(this.frmKthimet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKthimet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblEmriKlientit;
        private System.Windows.Forms.Label lblData_Dorezimit;
        private System.Windows.Forms.Label lblVetura_Id;
        private System.Windows.Forms.Label lblReturn_Id;
        private System.Windows.Forms.TextBox txtEmriKlientit;
        private System.Windows.Forms.DateTimePicker dtpData_Dorezimit;
        private System.Windows.Forms.TextBox txtReturn_Id;
        private System.Windows.Forms.Label lblDitetEShfrytezimit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veturaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriKlientitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDorezimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diteteShrytezimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCmimiTotal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtVetura_Id;
        private System.Windows.Forms.DateTimePicker dtpData_Huazimit;
        private System.Windows.Forms.Label lblDataHuazimit;
        private System.Windows.Forms.Label lblCmimi;
        private System.Windows.Forms.Label lblDitetE_Shfrytezimit_Rezultati;
        private System.Windows.Forms.Label lblCmimiVetures_Rezultati;
        private System.Windows.Forms.Label lblCmimiTotal_Rezultati;
        private System.Windows.Forms.Button btnKalkulo;
        private System.Windows.Forms.TextBox txtKlienti_Id;
        private System.Windows.Forms.Label lblKlienti_Id;
        private System.Windows.Forms.DataGridView dgvHuazimet;
        private System.Windows.Forms.DataGridView dgvKthimet;
        private System.Windows.Forms.TextBox txtRent_Id;
        private System.Windows.Forms.Label lblRent_Id;
        private System.Windows.Forms.Button btnClear;
    }
}