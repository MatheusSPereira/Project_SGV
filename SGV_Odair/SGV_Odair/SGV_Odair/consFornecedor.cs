using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SGV_Odair
{
    public partial class consFornecedor : Form
    {
        //caminhoDados
        configuracao caminho = new configuracao();

        public consFornecedor()
        {
            InitializeComponent();
            /*
            try
            {

                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader sr = new StreamReader(caminho.fullPath + "ufFornecedor.txt", Encoding.UTF7);
                //Lê a primeira linha do arquivo
                string linha = sr.ReadLine();
                //Continua lendo até o final do arquivo
                while (linha != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxUF.Items.Add(linha);
                    //Lê a próxima linha
                    linha = sr.ReadLine();
                }
                //Fecha o arquivo texto
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }
            */
        }

        private void consFornecedor_Load(object sender, EventArgs e)
        {
            MostraDados();
            carregaCombo();
        }

        private void MostraDados()
        {

            // Create an unbound DataGridView by declaring a column count.
            gridConsFornecedor.ColumnCount = 6;
            gridConsFornecedor.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            // Define o cabeçalho das colunas da grid
            gridConsFornecedor.Columns[0].Name = "Código";
            gridConsFornecedor.Columns[1].Name = "Razão Social";
            gridConsFornecedor.Columns[2].Name = "Endereço";
            gridConsFornecedor.Columns[3].Name = "Cidade";
            gridConsFornecedor.Columns[4].Name = "UF/Estado";
            gridConsFornecedor.Columns[5].Name = "CEP";

            //Criando um DataTable
            //DataTable dt = new DataTable();

            //Lendo Todas as linhas do arquivo CSV
            //string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razaoSocial.txt + fornecedor.txt" + "");
            string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razao&fornecedor.txt");

            DataGridViewRowCollection rows = this.gridConsFornecedor.Rows;

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

        private void cbxUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridConsFornecedor.Rows.Clear();
            // Create an unbound DataGridView by declaring a column count.
            gridConsFornecedor.ColumnCount = 6;
            gridConsFornecedor.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            // Define o cabeçalho das colunas da grid
            gridConsFornecedor.Columns[0].Name = "Código";
            gridConsFornecedor.Columns[1].Name = "Razão Social";
            gridConsFornecedor.Columns[2].Name = "Endereço";
            gridConsFornecedor.Columns[3].Name = "Cidade";
            gridConsFornecedor.Columns[4].Name = "UF/Estado";
            gridConsFornecedor.Columns[5].Name = "CEP";

            //Criando um DataTable
            //DataTable dt = new DataTable();

            //Lendo Todas as linhas do arquivo CSV
            //string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razaoSocial.txt + fornecedor.txt" + "");
            string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razao&fornecedor.txt");

            DataGridViewRowCollection rows = this.gridConsFornecedor.Rows;

            //Neste For, vamos percorrer todas as linhas que foram lidas do arquivo CSV
            for (int i = 0; i < Linha.Length; i++)
            {
                //Aqui Estamos pegando a linha atual, e separando os campos
                //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                //ele pega o texto e joga na outra posição do array temp, e assim por diante
                //até chegar no final da linha
                string[] campos = Linha[i].Split(Convert.ToChar(";"));

                if (cbxUF.Text == campos[4])
                {
                    rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5]);
                }
            }
        }
  

        void carregaCombo()
        {
            //CARREGA A COMBOBOX
            try
            {

                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader sr = new StreamReader(caminho.fullPath + "ufFornecedor.txt", Encoding.UTF7);
                //Lê a primeira linha do arquivo
                string linha = sr.ReadLine();
                //Continua lendo até o final do arquivo
                while (linha != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxUF.Items.Add(linha);
                    //Lê a próxima linha
                    linha = sr.ReadLine();
                }
                //Fecha o arquivo texto
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            gridConsFornecedor.Rows.Clear();
            MostraDados();
        }
    }
}