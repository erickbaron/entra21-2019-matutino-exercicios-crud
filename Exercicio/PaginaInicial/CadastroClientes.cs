using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaInicial
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void Inserir()
        {
            Clientes clientes = new Clientes();
            clientes.Nome = txtNome.Text;
            clientes.Saldo = Convert.ToDecimal(mtbSaldo.Text);
            clientes.Telefone = mtbTelefone.Text;
            clientes.Estado = cbEstado.SelectedItem.ToString();
            clientes.Cidade = txtCidade.Text;
            clientes.Bairro = txtBairro.Text;
            clientes.CEP = mtbCEP.Text;
            clientes.Logradouro = txtLogradouro.Text;
            clientes.Numero = Convert.ToInt32(txtNumero.Text);
            clientes.Complemento = txtComplemento.Text;
            clientes.Altura = Convert.ToDecimal(txtAltura.Text);
            clientes.Peso = Convert.ToDecimal(txtPeso.Text);
            if(ckbNomeSujo.Checked == true)
            {
                clientes.NomeSujo = true;
            }
            else
            {
                clientes.NomeSujo = false;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicios.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes(nome, saldo, telefone, estado, cidade, bairro, CEP, logradouro,
                                    numero, complemento, altura, peso, nome_Sujo)
                                    VALUES (@NOME, @SALDO, @TELEFONE, @ESTADO, @CIDADE, @BAIRRO, @CEP, @LOGRADOURO,
                                           @NUMERO, @COMPLEMENTO, @ALTURA, @PESO, @NOME_SUJO);";
            
            comando.Parameters.AddWithValue("@NOME",clientes.Nome);
            comando.Parameters.AddWithValue("@SALDO",clientes.Saldo);
            comando.Parameters.AddWithValue("@TELEFONE",clientes.Telefone);
            comando.Parameters.AddWithValue("@ESTADO",clientes.Estado);
            comando.Parameters.AddWithValue("@CIDADE",clientes.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO",clientes.Bairro);
            comando.Parameters.AddWithValue("@CEP", clientes.CEP);
            comando.Parameters.AddWithValue("@LOGRADOURO", clientes.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", clientes.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", clientes.Complemento);
            comando.Parameters.AddWithValue("@ALTURA", clientes.Altura);
            comando.Parameters.AddWithValue("@PESO", clientes.Peso);
            comando.Parameters.AddWithValue("@NOME_SUJO", clientes.NomeSujo);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro efetuado");
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
        }
    }
}
