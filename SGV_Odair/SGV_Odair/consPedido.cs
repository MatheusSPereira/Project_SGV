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
    public partial class consPedido : Form
    {
        configuracao caminho = new configuracao();
        public consPedido()
        {
            InitializeComponent();
        }


        private void consPedido_Load(object sender, EventArgs e)
        {
            MostraDados();
        }
        private void MostraDados()
        {

            // Create an unbound DataGridView by declaring a column count.
            gridConsPedido.ColumnCount = 5;
            gridConsPedido.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            // Define o cabeçalho das colunas da grid
            gridConsPedido.Columns[0].Name = "Código do Pedido";
            gridConsPedido.Columns[1].Name = "Data do Pedido";
            gridConsPedido.Columns[2].Name = "Descr. Produto";
            gridConsPedido.Columns[3].Name = "Tipo de Movimentação";
            gridConsPedido.Columns[4].Name = "Qtdade de Movimento";


            //Criando um DataTable
            //DataTable dt = new DataTable();

            //Lendo Todas as linhas do arquivo CSV
            //string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razaoSocial.txt + fornecedor.txt" + "");
            string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "pedido.txt");

            DataGridViewRowCollection rows = this.gridConsPedido.Rows;

            //Neste For, vamos percorrer todas as linhas que foram lidas do arquivo CSV
            for (int i = 0; i < Linha.Length; i++)
            {
                //Aqui Estamos pegando a linha atual, e separando os campos
                //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                //ele pega o texto e joga na outra posição do array temp, e assim por diante
                //até chegar no final da linha
                string[] campos = Linha[i].Split(Convert.ToChar(";"));
                rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5]);



            }


        }

    }
}
