namespace PaginaInicial
{
    partial class CadastroColaboradores
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.ckbProgramador = new System.Windows.Forms.CheckBox();
            this.dgvTabelaColaboradore = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProgramador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaColaboradore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(121, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(162, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 62);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 111);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 159);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(12, 226);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(15, 78);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 10;
            // 
            // mtbSalario
            // 
            this.mtbSalario.Location = new System.Drawing.Point(15, 127);
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(100, 20);
            this.mtbSalario.TabIndex = 11;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(15, 176);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 12;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(15, 199);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 13;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Repositor",
            "Médico",
            "Gari",
            "Catador de latinha"});
            this.cbCargo.Location = new System.Drawing.Point(15, 243);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 14;
            // 
            // ckbProgramador
            // 
            this.ckbProgramador.AutoSize = true;
            this.ckbProgramador.Location = new System.Drawing.Point(15, 280);
            this.ckbProgramador.Name = "ckbProgramador";
            this.ckbProgramador.Size = new System.Drawing.Size(86, 17);
            this.ckbProgramador.TabIndex = 15;
            this.ckbProgramador.Text = "Programador";
            this.ckbProgramador.UseVisualStyleBackColor = true;
            // 
            // dgvTabelaColaboradore
            // 
            this.dgvTabelaColaboradore.AllowUserToAddRows = false;
            this.dgvTabelaColaboradore.AllowUserToDeleteRows = false;
            this.dgvTabelaColaboradore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaColaboradore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnSalario,
            this.ColumnSeo,
            this.ColumnCargo,
            this.ColumProgramador});
            this.dgvTabelaColaboradore.Location = new System.Drawing.Point(221, 30);
            this.dgvTabelaColaboradore.Name = "dgvTabelaColaboradore";
            this.dgvTabelaColaboradore.ReadOnly = true;
            this.dgvTabelaColaboradore.Size = new System.Drawing.Size(539, 267);
            this.dgvTabelaColaboradore.TabIndex = 16;
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
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salário";
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.ReadOnly = true;
            // 
            // ColumnSeo
            // 
            this.ColumnSeo.HeaderText = "Sexo";
            this.ColumnSeo.Name = "ColumnSeo";
            this.ColumnSeo.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumProgramador
            // 
            this.ColumProgramador.HeaderText = "Programador";
            this.ColumProgramador.Name = "ColumProgramador";
            this.ColumProgramador.ReadOnly = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 321);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(100, 321);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // CadastroColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvTabelaColaboradore);
            this.Controls.Add(this.ckbProgramador);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.mtbSalario);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Name = "CadastroColaboradores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroColaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaColaboradore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.CheckBox ckbProgramador;
        private System.Windows.Forms.DataGridView dgvTabelaColaboradore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProgramador;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
    }
}