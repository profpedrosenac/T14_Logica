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

namespace MiniProjeto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtData.Text = "";
            txtQtde.Text = "";
            txtValorC.Text = "";
            txtValorV.Text = "";
            txtObs.Text = "";
            cboStatus.SelectedIndex = -1;
            txtID.Focus();
        }

        string stringConexao = MDIPrincipal.stringConexao;

        private void TestarConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string valorV = txtValorV.Text;
            valorV = valorV.Replace("R$ ","");
            valorV = valorV.Replace(",","." );
            string valorC = txtValorC.Text;
            valorC = valorC.Replace("R$ ", "");
            valorC = valorC.Replace(",", ".");
            
            string sql = "set dateformat dmy insert into produto" +
                "(nome_Produto,qtde_Produto,Vcusto_Produto,Vvenda_Produto,obs_Produto)" +
                "values" +
                "('" + txtNome.Text + "'," + txtQtde.Text + "," + valorC + "," + valorV + ",'" + txtObs.Text + "')Select Scope_identity()";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    btoLimpar.PerformClick();
                    txtID.Text = leitura[0].ToString();
                    MessageBox.Show("Cadastro realizado com sucesso");
                    btoPesquisar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto = " + txtID.Text ;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtID.Text = leitura[0].ToString();
                    txtNome.Text = leitura[1].ToString();
                    txtData.Text = leitura[2].ToString();
                    txtQtde.Text = leitura[3].ToString();
                    txtValorC.Text = (decimal.Parse(leitura[4].ToString())).ToString("C");
                    txtValorV.Text = (decimal.Parse(leitura[5].ToString())).ToString("C");
                    txtObs.Text = leitura[6].ToString();
                    cboStatus.Text = leitura[7].ToString();
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtValorC_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtValorC.Text, out valor))
            {
                txtValorC.Text = valor.ToString("C");
            }
            else
            {
                txtValorC.Text = "";
            }
        }

        private void txtValorC_Enter(object sender, EventArgs e)
        {
            txtValorC.Text = txtValorC.Text.Replace("R$ ","");
        }

        private void txtValorV_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtValorV.Text, out valor))
            {
                txtValorV.Text = valor.ToString("C");
            }
            else
            {
                txtValorV.Text = "";
            }
        }

        private void txtValorV_Enter(object sender, EventArgs e)
        {
            txtValorV.Text = txtValorV.Text.Replace("R$ ", "");
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from produto where id_produto = " + txtID.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    btoLimpar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string valorV = txtValorV.Text;
            valorV = valorV.Replace("R$ ", "");
            valorV = valorV.Replace(",", ".");
            string valorC = txtValorC.Text;
            valorC = valorC.Replace("R$ ", "");
            valorC = valorC.Replace(",", ".");

            string sql = "set dateformat dmy update produto set " +
                "nome_Produto='" + txtNome.Text + "'," +
                "data_Produto='" + txtData.Text + "'," +
                "qtde_Produto=" + txtQtde.Text + "," +
                "Vcusto_Produto=" + valorC + "," +
                "Vvenda_Produto=" + valorV + "," +
                "obs_Produto='" + txtObs.Text + "'," +
                "status_Produto='" + cboStatus.Text + "'" +
                " where id_produto = " + txtID.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                    btoPesquisar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
