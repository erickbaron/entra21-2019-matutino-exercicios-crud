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
    public partial class CadastroPeixes : Form
    {
        public CadastroPeixes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
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
            if (dgvTabelaPeixes.Rows.Count < 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }
            if (dgvTabelaPeixes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cadastre um peixe");
                return;
            }
            DialogResult caixaDeDialogo = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);
            if (caixaDeDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM tabelaPeixes 
                                       WHERE id = @ID;";
                int id = Convert.ToInt32(dgvTabelaPeixes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                AtualizarTabela();

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
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
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

        private void Alterar()
        {
            Peixe peixe = new Peixe();
            peixe.Id = Convert.ToInt32(lblId.Text);
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text);
            peixe.Quantidade = Convert.ToInt32(nudQuantidade.Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE tabelaPeixes SET
            nome = @NOME,
            raca = @RACA,
            preco = @PRECO,
            quantidade = @QUANTIDADE
            WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", peixe.Id);
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
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, raca,preco, quantidade FROM tabelaPeixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvTabelaPeixes.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
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

        private void dgvTabelaPeixes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvTabelaPeixes.CurrentRow.Cells[0].Value);


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, raca,preco, quantidade FROM tabelaPeixes
                                    WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];

            Peixe peixe = new Peixe();
            peixe.Id = Convert.ToInt32(linha["id"]);
            peixe.Nome = linha["nome"].ToString();
            peixe.Raca = linha["raca"].ToString();
            peixe.Preco = Convert.ToDecimal(linha["preco"]);
            peixe.Quantidade = Convert.ToInt32(linha["quantidade"]);
            lblId.Text = peixe.Id.ToString();
            txtNome.Text = peixe.Nome;
            cbRaca.SelectedItem = peixe.Raca;
            nudQuantidade.Value = peixe.Quantidade;
            mtbPreco.Text = peixe.Preco.ToString();
        }

        private void CadastroPeixes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void CadastroPeixes_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
