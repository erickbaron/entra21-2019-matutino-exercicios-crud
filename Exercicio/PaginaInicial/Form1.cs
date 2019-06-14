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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Inserir()
        {
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Nome = txtNome.Text;
            colaboradores.CPF = mtbCPF.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text);

            string sexo = "";
            if(rbFeminino.Checked == true)
            {
                sexo = "Feminino";
            }
            else if (rbMasculino.Checked == true)
            {
                sexo = "Masculino";
            }
            else
            {
             //   MessageBox.Show("Selecione uma das opções para sexo);
            }
           // colaboradores.Sexo = 
            //colaboradores
            //colaboradores
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
