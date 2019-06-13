namespace PaginaInicial
{
    partial class CadastroPeixes
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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvTabelaPeixes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaPeixes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(13, 13);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(32, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Cód.:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(13, 89);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 3;
            this.lblRaca.Text = "Raça";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 142);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(13, 186);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 6;
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Tilápia",
            "Carpa",
            "Pacu",
            "Bagre",
            "Pirarocu",
            "Piranha",
            "Dourado",
            "Espada",
            "Baiacu",
            "Garoupa",
            "Robalo"});
            this.cbRaca.Location = new System.Drawing.Point(16, 106);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(156, 21);
            this.cbRaca.TabIndex = 7;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(16, 159);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(156, 20);
            this.mtbPreco.TabIndex = 8;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(16, 203);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(156, 20);
            this.nudQuantidade.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 241);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(97, 241);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dgvTabelaPeixes
            // 
            this.dgvTabelaPeixes.AllowUserToAddRows = false;
            this.dgvTabelaPeixes.AllowUserToDeleteRows = false;
            this.dgvTabelaPeixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaPeixes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnPreco,
            this.ColumnQuantidade});
            this.dgvTabelaPeixes.Location = new System.Drawing.Point(209, 13);
            this.dgvTabelaPeixes.Name = "dgvTabelaPeixes";
            this.dgvTabelaPeixes.ReadOnly = true;
            this.dgvTabelaPeixes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelaPeixes.Size = new System.Drawing.Size(341, 251);
            this.dgvTabelaPeixes.TabIndex = 12;
            this.dgvTabelaPeixes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelaPeixes_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Cód.";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            // 
            // CadastroPeixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 299);
            this.Controls.Add(this.dgvTabelaPeixes);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCod);
            this.Name = "CadastroPeixes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CadastroPeixes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaPeixes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgvTabelaPeixes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
    }
}