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
    public partial class consCategoria : Form
    {
        configuracao caminho = new configuracao();
        public consCategoria()
        {
            InitializeComponent();
        }

        private void consCategoria_Load(object sender, EventArgs e)
        {
            MostraDados();
        }


        private void MostraDados()
        {

            // Create an unbound DataGridView by declaring a column count.
            gridCategorias.ColumnCount = 2;
            gridCategorias.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            // Define o cabeçalho das colunas da grid
            gridCategorias.Columns[0].Name = "Categoria";
            gridCategorias.Columns[1].Name = "Descrição";



            //Criando um DataTable
            //DataTable dt = new DataTable();

            //Lendo Todas as linhas do arquivo CSV
            //string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razaoSocial.txt + fornecedor.txt" + "");
            string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "categ&desc.txt");

            DataGridViewRowCollection rows = this.gridCategorias.Rows;

            //Neste For, vamos percorrer todas as linhas que foram lidas do arquivo CSV
            for (int i = 0; i < Linha.Length; i++)
            {
                //Aqui Estamos pegando a linha atual, e separando os campos
                //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                //ele pega o texto e joga na outra posição do array temp, e assim por diante
                //até chegar no final da linha
                string[] campos = Linha[i].Split(Convert.ToChar(";"));
                rows.Add(campos[0], campos[1]);



            }


        }
    }
}
