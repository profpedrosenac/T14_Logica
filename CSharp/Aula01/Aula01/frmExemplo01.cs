namespace Aula01
{
    public partial class frmExemplo01 : Form
    {
        public frmExemplo01()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu nome é: " + txtNome.Text);
            txtNome.Text = "";
        }
    }
}