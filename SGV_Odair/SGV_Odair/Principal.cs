using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_Odair
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consFornecedor frmconsFornecedor = new consFornecedor();
            frmconsFornecedor.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedor frmFornecedor = new fornecedor();
            frmFornecedor.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produto frmProduto = new produto();
            frmProduto.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consProduto frmconsProduto = new consProduto();
            frmconsProduto.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedido frmPedido = new pedido();
            frmPedido.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consPedido frmConsPedido = new consPedido();
            frmConsPedido.Show();
        }
    }
}
