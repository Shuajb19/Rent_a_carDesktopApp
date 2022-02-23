
namespace DemoCarRent
{
    partial class frmKlientat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlientat));
            this.lblKlientId = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefoni = new System.Windows.Forms.Label();
            this.lblQyteti = new System.Windows.Forms.Label();
            this.txtKlient_Id = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtQyteti = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefoni = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKlientat = new System.Windows.Forms.Label();
            this.dgvKlientat = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.klientatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKlientId
            // 
            resources.ApplyResources(this.lblKlientId, "lblKlientId");
            this.lblKlientId.Name = "lblKlientId";
            // 
            // lblEmri
            // 
            resources.ApplyResources(this.lblEmri, "lblEmri");
            this.lblEmri.Name = "lblEmri";
            // 
            // lblMbiemri
            // 
            resources.ApplyResources(this.lblMbiemri, "lblMbiemri");
            this.lblMbiemri.Name = "lblMbiemri";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblTelefoni
            // 
            resources.ApplyResources(this.lblTelefoni, "lblTelefoni");
            this.lblTelefoni.Name = "lblTelefoni";
            // 
            // lblQyteti
            // 
            resources.ApplyResources(this.lblQyteti, "lblQyteti");
            this.lblQyteti.Name = "lblQyteti";
            // 
            // txtKlient_Id
            // 
            resources.ApplyResources(this.txtKlient_Id, "txtKlient_Id");
            this.txtKlient_Id.Name = "txtKlient_Id";
            // 
            // txtEmri
            // 
            resources.ApplyResources(this.txtEmri, "txtEmri");
            this.txtEmri.Name = "txtEmri";
            // 
            // txtQyteti
            // 
            resources.ApplyResources(this.txtQyteti, "txtQyteti");
            this.txtQyteti.Name = "txtQyteti";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtTelefoni
            // 
            resources.ApplyResources(this.txtTelefoni, "txtTelefoni");
            this.txtTelefoni.Name = "txtTelefoni";
            // 
            // txtMbiemri
            // 
            resources.ApplyResources(this.txtMbiemri, "txtMbiemri");
            this.txtMbiemri.Name = "txtMbiemri";
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
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblKlientat);
            this.panel1.Name = "panel1";
            // 
            // lblKlientat
            // 
            resources.ApplyResources(this.lblKlientat, "lblKlientat");
            this.lblKlientat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKlientat.Name = "lblKlientat";
            // 
            // dgvKlientat
            // 
            resources.ApplyResources(this.dgvKlientat, "dgvKlientat");
            this.dgvKlientat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlientat.Name = "dgvKlientat";
            this.dgvKlientat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlientat_CellContentClick);
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
            // klientatBindingSource
            // 
            this.klientatBindingSource.DataMember = "Klientat";
            // 
            // frmKlientat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvKlientat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.txtTelefoni);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtQyteti);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtKlient_Id);
            this.Controls.Add(this.lblQyteti);
            this.Controls.Add(this.lblTelefoni);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMbiemri);
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.lblKlientId);
            this.Name = "frmKlientat";
            this.Load += new System.EventHandler(this.Klientat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlientId;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefoni;
        private System.Windows.Forms.Label lblQyteti;
        private System.Windows.Forms.TextBox txtKlient_Id;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtQyteti;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefoni;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.BindingSource klientatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbiemriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qytetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKlientat;
        private System.Windows.Forms.DataGridView dgvKlientat;
        private System.Windows.Forms.Button btnClear;
    }
}