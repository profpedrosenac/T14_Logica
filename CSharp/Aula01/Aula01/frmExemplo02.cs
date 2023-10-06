using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class frmExemplo02 : Form
    {
        public frmExemplo02()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtNomeCompleto.Text = "";
            txtNome.Focus();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, nome deve ser preenchido");
                txtNome.Focus();
                return;
            }

            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Erro, sobrenome deve ser preenchido");
                txtSobrenome.Focus();
                return;
            }

            txtNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }
    }
}
