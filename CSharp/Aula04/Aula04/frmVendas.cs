namespace Aula04
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProdutoValor.SelectedIndex = cboProduto.SelectedIndex;
        }

        float valorTotal;
        private void btoAdd_Click(object sender, EventArgs e)
        {            
            float valorUnitario;
            float qtde;
            string itemProduto;
            float totalItem;

            valorUnitario = float.Parse(cboProdutoValor.Text.Replace("R$ ",""));
            qtde = float.Parse(txtQtde.Value.ToString());

            totalItem = valorUnitario * qtde;

            //MessageBox.Show(valorUnitario.ToString());

            itemProduto = cboProduto.Text + " - " + qtde + " - " + 
                cboProdutoValor.Text + " | " + totalItem.ToString("C");

            listItemProdutos.Items.Add(itemProduto);

            valorTotal = valorTotal + totalItem;
            lblResult.Text = valorTotal.ToString("C");
        }

        private void listItemProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btoExcluid_Click(object sender, EventArgs e)
        {
            if (listItemProdutos.SelectedIndex == 0 || listItemProdutos.SelectedIndex == -1)
            {
                return;
            }
            string teste = listItemProdutos.SelectedItems[0].ToString();
            float valorItem = float.Parse(teste.Substring(teste.IndexOf("|") + 5));

            valorTotal = valorTotal - valorItem;
            lblResult.Text = valorTotal.ToString("C");

            listItemProdutos.Items.RemoveAt(listItemProdutos.SelectedIndex);
        }
    }
}