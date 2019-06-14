namespace PaginaInicial
{
    partial class PaginaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnCadastroPeixes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Location = new System.Drawing.Point(267, 71);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(221, 271);
            this.btnColaboradores.TabIndex = 0;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastroPeixes
            // 
            this.btnCadastroPeixes.Location = new System.Drawing.Point(40, 71);
            this.btnCadastroPeixes.Name = "btnCadastroPeixes";
            this.btnCadastroPeixes.Size = new System.Drawing.Size(221, 271);
            this.btnCadastroPeixes.TabIndex = 1;
            this.btnCadastroPeixes.Text = "Cadstro de Peixes";
            this.btnCadastroPeixes.UseVisualStyleBackColor = true;
            this.btnCadastroPeixes.Click += new System.EventHandler(this.btnCadastroPeixes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 271);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.btnCadastroPeixes);
            this.Name = "PaginaInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnCadastroPeixes;
        private System.Windows.Forms.Button button3;
    }
}

