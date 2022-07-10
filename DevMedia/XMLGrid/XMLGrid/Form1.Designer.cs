namespace XMLGrid
{
    partial class XMLGrid
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
            this.grdEditar = new System.Windows.Forms.DataGridView();
            this.colCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEditar
            // 
            this.grdEditar.AllowUserToAddRows = false;
            this.grdEditar.AllowUserToDeleteRows = false;
            this.grdEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEditar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEditar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCampo,
            this.colValor});
            this.grdEditar.Location = new System.Drawing.Point(12, 49);
            this.grdEditar.Name = "grdEditar";
            this.grdEditar.RowHeadersVisible = false;
            this.grdEditar.Size = new System.Drawing.Size(913, 388);
            this.grdEditar.TabIndex = 0;
            this.grdEditar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCampo
            // 
            this.colCampo.HeaderText = "Campo";
            this.colCampo.Name = "colCampo";
            this.colCampo.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Arquivo Xml (*xml) | *.xml";
            this.openFileDialog1.Title = "Escolha o arquivo para abrir";
            // 
            // XMLGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 449);
            this.Controls.Add(this.grdEditar);
            this.Name = "XMLGrid";
            this.Text = "XMLGrid";
            ((System.ComponentModel.ISupportInitialize)(this.grdEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

