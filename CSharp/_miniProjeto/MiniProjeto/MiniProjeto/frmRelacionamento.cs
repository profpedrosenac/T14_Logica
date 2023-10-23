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
    public partial class frmRelacionamento : Form
    {
        public frmRelacionamento()
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
            }
        }

        private void frmRelacionamento_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarComboProduto();
        }

        private void CarregarComboProduto()
        {
            string sql = "select id_produto, nome_produto from produto";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable tabela = new DataTable();

            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                tabela.Load(leitura);

                cboIDProduto.DisplayMember = "id_produto";
                cboIDProduto.DataSource = tabela;

                cboNomeProduto.DisplayMember = "nome_produto";
                cboNomeProduto.DataSource = tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
