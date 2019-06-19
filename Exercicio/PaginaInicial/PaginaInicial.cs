using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaInicial
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastroPeixes_Click(object sender, EventArgs e)
        {
            CadastroPeixes form = new CadastroPeixes();
            form.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroColaboradores form = new CadastroColaboradores();
            form.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes form = new CadastroClientes();
            form.Visible = true;
        }
    }
}
