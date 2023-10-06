namespace Aula02
{
    public partial class frmMediaEscolar : Form
    {
        public frmMediaEscolar()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtmedia.Text = "";
            txtStatus.Text = "";
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtn4.Text = "";
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float n1; float n2; float n3; float n4; float media;

            if (!float.TryParse(txtn1.Text, out n1))
            {
                MessageBox.Show("Erro, N1 deve ser número");
                txtn1.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn1.Focus();
                return;
            }
            if (!float.TryParse(txtn2.Text, out n2))
            {
                MessageBox.Show("Erro, N2 deve ser número");
                txtn2.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn2.Focus();
                return;
            }
            if (!float.TryParse(txtn3.Text, out n3))
            {
                MessageBox.Show("Erro, N3 deve ser número");
                txtn3.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn3.Focus();
                return;
            }
            if (!float.TryParse(txtn4.Text, out n4))
            {
                MessageBox.Show("Erro, N4 deve ser número");
                txtn4.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn4.Focus();
                return;
            }

            if (n1 < 0 || n1 >10)
            {
                MessageBox.Show("Erro, N1 deve estar entre 0 e 10");
                txtn1.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn1.Focus();
                return;

            }
            if (n2 < 0 || n2 > 10)
            {
                MessageBox.Show("Erro, N2 deve estar entre 0 e 10");
                txtn2.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn2.Focus();
                return;

            }
            if (n3 < 0 || n3 > 10)
            {
                MessageBox.Show("Erro, N3 deve estar entre 0 e 10");
                txtn3.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn3.Focus();
                return;

            }
            if (n4 < 0 || n4 > 10)
            {
                MessageBox.Show("Erro, N4 deve estar entre 0 e 10");
                txtn4.Text = "";
                txtmedia.Text = "";
                txtStatus.Text = "";
                txtn4.Focus();
                return;

            }

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 7)
            {
                txtStatus.Text = "APROVADO";
                //txtStatus.BackColor = Color.Blue;
                txtStatus.ForeColor = Color.Blue;
            }
            else if (media < 5)
            {
                txtStatus.Text = "REPROVADO";
                //txtStatus.BackColor = Color.Red;
                txtStatus.ForeColor = Color.Red;
            }
            else
            {
                txtStatus.Text = "EXAME";
                //txtStatus.BackColor = Color.Yellow;
                txtStatus.ForeColor = Color.Yellow;
            }

            txtmedia.Text = media.ToString();
        }
    }
}