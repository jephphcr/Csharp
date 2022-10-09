namespace WindowsFormsApp1
{
    partial class frmPessoa
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
            this.ctxtMenuExcluir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabResgistration = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.dgtListaClientes = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabERP = new System.Windows.Forms.TabControl();
            this.ctxtMenuExcluir.SuspendLayout();
            this.tabResgistration.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtListaClientes)).BeginInit();
            this.tabERP.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtMenuExcluir
            // 
            this.ctxtMenuExcluir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.ctxtMenuExcluir.Name = "contextMenuStrip1";
            this.ctxtMenuExcluir.Size = new System.Drawing.Size(110, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // tabResgistration
            // 
            this.tabResgistration.Controls.Add(this.txtId);
            this.tabResgistration.Controls.Add(this.txtEmail);
            this.tabResgistration.Controls.Add(this.txtName);
            this.tabResgistration.Controls.Add(this.label1);
            this.tabResgistration.Controls.Add(this.btnSave);
            this.tabResgistration.Controls.Add(this.mskPhone);
            this.tabResgistration.Controls.Add(this.mskCPF);
            this.tabResgistration.Controls.Add(this.lblEmail);
            this.tabResgistration.Controls.Add(this.lblPhone);
            this.tabResgistration.Controls.Add(this.lblCPF);
            this.tabResgistration.Controls.Add(this.lblName);
            this.tabResgistration.Location = new System.Drawing.Point(4, 22);
            this.tabResgistration.Name = "tabResgistration";
            this.tabResgistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabResgistration.Size = new System.Drawing.Size(664, 341);
            this.tabResgistration.TabIndex = 1;
            this.tabResgistration.Text = "Cadastro";
            this.tabResgistration.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(309, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(309, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(309, 154);
            this.mskPhone.Mask = "(99) 99999-9999";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(100, 20);
            this.mskPhone.TabIndex = 14;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(309, 107);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(263, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(263, 154);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(263, 110);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(84, 13);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "Lista de Clientes";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(262, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.button1);
            this.tabCustomers.Controls.Add(this.lblSearch);
            this.tabCustomers.Controls.Add(this.btnName);
            this.tabCustomers.Controls.Add(this.dgtListaClientes);
            this.tabCustomers.Controls.Add(this.txtSearch);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(664, 341);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Lista de Clientes";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testeTab_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(104, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(293, 29);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Find";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // dgtListaClientes
            // 
            this.dgtListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtListaClientes.ContextMenuStrip = this.ctxtMenuExcluir;
            this.dgtListaClientes.Location = new System.Drawing.Point(0, 87);
            this.dgtListaClientes.Name = "dgtListaClientes";
            this.dgtListaClientes.Size = new System.Drawing.Size(664, 254);
            this.dgtListaClientes.TabIndex = 1;
            this.dgtListaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtListaClientes_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(169, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // tabERP
            // 
            this.tabERP.Controls.Add(this.tabCustomers);
            this.tabERP.Controls.Add(this.tabResgistration);
            this.tabERP.Location = new System.Drawing.Point(12, 12);
            this.tabERP.Name = "tabERP";
            this.tabERP.SelectedIndex = 0;
            this.tabERP.Size = new System.Drawing.Size(672, 367);
            this.tabERP.TabIndex = 0;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 391);
            this.Controls.Add(this.tabERP);
            this.Name = "frmPessoa";
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.frmPessoa_Load);
            this.ctxtMenuExcluir.ResumeLayout(false);
            this.tabResgistration.ResumeLayout(false);
            this.tabResgistration.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtListaClientes)).EndInit();
            this.tabERP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxtMenuExcluir;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.TabPage tabResgistration;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.DataGridView dgtListaClientes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabControl tabERP;
        private System.Windows.Forms.TabPage tabCustomers;
    }
}

