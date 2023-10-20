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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string stringConexao = MDIPrincipal.stringConexao;

        private void TestarConexao()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConexao);
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "login_usuario = '"+txtLogin.Text+"' and " +
                "senha_usuario = '"+txtSenha.Text+"'";

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
                    MDIPrincipal.idUsuario = leitura[0].ToString();
                    MDIPrincipal.nomeUsuario = leitura[1].ToString();
                    MDIPrincipal.loginUsuario = leitura[2].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro, usuário ou senha inválido");
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


        private void frmLogin_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
    }
}
