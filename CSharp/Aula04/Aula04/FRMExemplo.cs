using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04
{
    public partial class FRMExemplo : Form
    {
        public FRMExemplo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list01.Items.Add(cboProduto.Text);
        }
    }
}
