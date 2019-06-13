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
    public partial class CadastroPeixes : Form
    {
        public CadastroPeixes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(lblId == 0)
            {
            Inserir();
            }
            else
            {
                Alterar();
            }
        }

        private void Inserir()
        {
            Peixe peixe = new Peixe();
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text);
            peixe.Quantidade = Convert.ToInt32(nudQuantidade.Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Execicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO tabelaPeixes (nome, raca, preco, quantidade)
                                    VALUES (@NOME, @RACA, @PRECO, @QUANTIDADE)";
            comando.Parameters.AddWithValue("@NOME", peixe.Nome);
            comando.Parameters.AddWithValue("@RACA", peixe.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixe.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixe.Quantidade);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro efetuado");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cbRaca.SelectedIndex = -1;
            mtbPreco.Clear();
            nudQuantidade.Value = 0;
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Execicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, raca,preco, quantidade FROM tabelaPeixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            //dgvTabelaPeixes.RowCount = 0;
            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Peixe peixe = new Peixe();
                peixe.Id = Convert.ToInt32(linha["id"]);
                peixe.Nome = linha["nome"].ToString();
                peixe.Raca = linha["raca"].ToString();
                peixe.Preco = Convert.ToDecimal(linha["preco"]);
                peixe.Quantidade = Convert.ToInt32(linha["quantidade"]);
                dgvTabelaPeixes.Rows.Add(new string[]
                    {
                        peixe.Id.ToString(), peixe.Nome.ToString(), peixe.Raca.ToString(), peixe.Preco.ToString(),
                        peixe.Quantidade.ToString()
                    });
            }

            conexao.Close();
        }



    }
}
