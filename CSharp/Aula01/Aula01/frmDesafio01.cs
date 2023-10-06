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
    public partial class frmDesafio01 : Form
    {
        public frmDesafio01()
        {
            InitializeComponent();
        }

        private void btoSoma_Click(object sender, EventArgs e)
        {
            float n1;
            float n2;

            if (float.TryParse(txtN1.Text, out n1) == false)
            {
                MessageBox.Show("Erro, n1 deve ser numérico");
                return;
            }
            if (float.TryParse(txtN2.Text, out n2) == false)
            {
                MessageBox.Show("Erro, n2 deve ser numérico");
                return;
            }

            //n1 = float.Parse(txtN1.Text);
            //n2 = float.Parse(txtN2.Text);

            lblResult.Text = (n1+n2).ToString();
            //lblResult.Text = (float.Parse(txtN1.Text) + float.Parse(txtN2.Text)).ToString();
        }
    }
}
