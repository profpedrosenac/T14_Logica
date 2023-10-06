namespace Aula03
{
    public partial class frmAula03 : Form
    {
        public frmAula03()
        {
            InitializeComponent();
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorUnitario.SelectedIndex = cboProduto.SelectedIndex;
            
            //if (cboProduto.SelectedIndex == 0)
            //{
            //    txtValorUnitario.Text = "2,50";
            //}
            //else if (cboProduto.SelectedIndex == 1)
            //{
            //    txtValorUnitario.Text = "8,30";
            //}
            //else if (cboProduto.SelectedIndex == 2)
            //{
            //    txtValorUnitario.Text = "3,45";
            //}
            //else
            //{
            //    txtValorUnitario.Text = "";
            //}
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoDesconto_Click(object sender, EventArgs e)
        {
            float vUnit; float qtde; float total;

            qtde = float.Parse(txtQtde.Text);
            vUnit = float.Parse(txtValorUnitario.Text);

            total = vUnit * qtde;
            total = total * 0.8F;
            lblResult.Text = total.ToString("C");
        }

        private void btoFim_Click(object sender, EventArgs e)
        {
            float vUnit; float qtde; float total;

            qtde = float.Parse(txtQtde.Text);
            vUnit = float.Parse(txtValorUnitario.Text);

            total = vUnit * qtde;
            lblResult.Text = total.ToString("C");
        }
    }
}