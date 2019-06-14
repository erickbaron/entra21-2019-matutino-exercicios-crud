﻿using System;
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
    public partial class CadastroColaboradores : Form
    {
        public CadastroColaboradores()
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
               MessageBox.Show("Selecione uma das opções para sexo");
                return;
            }
            colaboradores.Sexo = sexo;

            colaboradores.Cargo = cbCargo.SelectedItem.ToString();

            bool programador = false;
            if (ckbProgramador.Checked == true)
            {
                programador = true;
            }
            else
            {
                programador = false;
            }
            colaboradores.Programador = programador;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO colaboradores (nome, cpf, salario, sexo, cargo, programador)
                                    VALUES(@NOME, @CPF, @SALARIO, @SEXO, @CARGO, @PROGRAMADOR)";

            comando.Parameters.AddWithValue("@NOME",colaboradores.Nome);
            comando.Parameters.AddWithValue("@CPF",colaboradores.CPF);
            comando.Parameters.AddWithValue("@SALARIO",colaboradores.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO",colaboradores.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR",colaboradores.Programador);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro efetuado");
            LimparCampos();
            conexao.Close();
            AtualiarTabela();
            
        }

        public void Alterar()
        {
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Id = Convert.ToInt32(lblId);
            colaboradores.Nome = txtNome.Text;
            colaboradores.CPF = mtbCPF.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text);

            string sexo = "";
            if (rbFeminino.Checked == true)
            {
                sexo = "Feminino";
            }
            else if (rbMasculino.Checked == true)
            {
                sexo = "Masculino";
            }

            colaboradores.Sexo = sexo;

            colaboradores.Cargo = cbCargo.SelectedItem.ToString();

            if (ckbProgramador.Checked == true)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false;
            }

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mtbCPF.Clear();
            mtbSalario.Clear();
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            cbCargo.SelectedIndex = -1;
            ckbProgramador.Checked = false;
        }

        public void AtualiarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, cpf, salario, sexo, cargo, programador FROM colaboradores";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvTabelaColaboradore.RowCount = 0;

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Colaboradores colaboradores = new Colaboradores();
                colaboradores.Id = Convert.ToInt32(linha["id"]);
                colaboradores.Nome = linha["nome"].ToString();
                colaboradores.CPF = linha["cpf"].ToString();
                colaboradores.Salario = Convert.ToDecimal(linha["salario"]);
                colaboradores.Sexo = linha["sexo"].ToString();
                colaboradores.Cargo = linha["cargo"].ToString();
                colaboradores.Programador = Convert.ToBoolean(linha["programador"]);
                dgvTabelaColaboradore.Rows.Add(new string[]
                    {
                        colaboradores.Id.ToString(), colaboradores.Nome.ToString(), colaboradores.CPF.ToString(), colaboradores.Salario.ToString(),
                        colaboradores.Sexo.ToString() , colaboradores.Cargo.ToString(), colaboradores.Programador.ToString()
                    });
                conexao.Close();
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(lblId.Text == "0")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {


        }

        private void CadastroColaboradores_Load(object sender, EventArgs e)
        {
            AtualiarTabela();
        }
    }
}