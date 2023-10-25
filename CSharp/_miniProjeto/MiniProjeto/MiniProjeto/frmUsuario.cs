using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProjeto
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
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
                Application.Exit();
            }
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtData.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cboStatus.SelectedIndex = -1;
            txtObs.Text = "";
            txtCodigo.Focus();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            carregarDataGridUsuario();
        }

        private void carregarDataGridUsuario()
        {
            string sql = "select id_usuario as 'ID', nome_usuario as 'Nome', " +
                "login_usuario as 'Login', status_usuario as 'Status' from usuario " +
                "where nome_usuario like '%"+ txtNomePesquisa.Text+"%'";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();

            conexao.Open();

            try
            {
                ad.Fill(ds);

                dataGridUsuario.DataSource = ds.Tables[0];
                dataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuario.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            //antes do código para o bd deve-se fazer as validações
            string sql = "insert into usuario" +
                "(nome_usuario,login_usuario,senha_usuario,obs_usuario)" +
            "values" +
                "('" + txtNome.Text + "','"+txtLogin.Text+"','"+txtSenha.Text+"','"+txtObs.Text+"')" +
                "select scope_identity()";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                //int i = cmd.ExecuteNonQuery();

                //if (i == 1)
                //{
                //    MessageBox.Show("Cadastro Realizado com sucesso");
                //}

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btoLimpar.PerformClick();

                    txtCodigo.Text = leitura[0].ToString();
                    MessageBox.Show("Cadastro realizado com sucesso");

                    botPesquisar.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from usuario where id_usuario = " + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conexao);
            cmd.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possível excluir o dado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update usuario set " +
                "nome_usuario = '"+txtNome.Text+"'," +
                "login_usuario = '"+txtLogin.Text+"'," +
                "senha_usuario = '"+txtSenha.Text+"'," +
                "obs_usuario = '"+txtObs.Text+"'," +
                "status_usuario = '"+cboStatus.Text+"'" +
            "where id_usuario = " + txtCodigo.Text;
                

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possível alterar os dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void botPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where id_usuario=" + txtCodigo.Text ;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCodigo.Text = leitura[0].ToString();
                    txtNome.Text = leitura[1].ToString();
                    txtLogin.Text = leitura[2].ToString();
                    txtSenha.Text = leitura[3].ToString();
                    txtData.Text = leitura[4].ToString();
                    txtObs.Text = leitura[5].ToString();
                    cboStatus.Text = leitura[6].ToString();
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridUsuario.CurrentRow.Cells["ID"].Value.ToString();
            botPesquisar.PerformClick();
        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            carregarDataGridUsuario();
        }
    }
}
