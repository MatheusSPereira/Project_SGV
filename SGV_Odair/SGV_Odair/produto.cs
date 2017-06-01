using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_Odair
{
    public struct cadProduto
    {
        public string codigo;
        public string descProduto;
        public string categoria;
        public string razaoSocial;
        public string qtdEstoque;
        public string estMinimo;
        public string valUnit;

    }

    public partial class produto : Form
    {
        //caminhgo para fullpath dos arquivos *txt
        configuracao caminho = new configuracao();

        int totallinha = 0;//variavel global
        //numero total de linhas no arquivo texto
        //vetro da minha struct 
        cadProduto[] cadProd;  //vetor global da minha estrutura Cadastro
        int p;
        //marcar posição de um registro da struct 

        int modo;
        
        public produto()
        {
            InitializeComponent();

            carregaCombos();
        }

        //========== INICIO ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== INICIO ============ 
        private void produto_Load(object sender, EventArgs e)
        {
            ModoNavegacao();
            //1. contar numero de linhas do arquivo texto 
            // esse dado sera utilizado posteriormente
            //para inicializar o vetor regaluno
            contarlinhas();
            //defini o tamanho do vetor atraves da função acima 
            cadProd = new cadProduto[totallinha];
            //carregar o vetor Cadastro
            carregarProduto();
            mostrarDados();
            Atualiza();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ModoEdicao();
            modo = 2;
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p++;
            if (p == totallinha)
            {
                p--;

            }
            mostrarDados();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p--;
            if (p < 0)
            {
                p++;

            }
            mostrarDados();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p = totallinha - 1;
            mostrarDados();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p = 0;
            mostrarDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoEdicao();

            txtCod.Clear();
            txtDescProdt.Clear();
            txtEstoMin.Clear();
            txtQtdEstoque.Clear();
            txtvalUnit.Clear();
            txtCod.Focus();

            modo = 1;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (modo == 1)//modo == 1 é para adicionar um novo registro
            {
                Incluir();
                //carregarFornecedor();
                //Atualiza();
                mostrarDados();
            }

            if (modo == 2)//modo == 2 é para atualizar o registro
            {
                Atualiza();
                alterarDados();
                //carregarFornecedor();
                mostrarDados();
            }

            if (modo == 3)//modo == 3 para excluir o registro que está sendo mostrado
            {
                excluir();
                //carregarFornecedor();
                mostrarDados();
            }


            ModoNavegacao();
            carregarProduto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModoEdicao();
            excluir();
            modo = 3;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consProduto frmConsProduto = new consProduto();
            frmConsProduto.Show();
        }

        //========== FIM ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== FIM ============

        void Incluir()
        {
            StreamWriter graProd1 = new StreamWriter(caminho.fullPath + "produto.txt", true, Encoding.UTF8);
            graProd1.WriteLine(txtCod.Text + ";" + txtDescProdt.Text + ";" + cbxCat.Text + ";" + cbxRazSoc.Text + ";" + txtQtdEstoque.Text + ";" + txtEstoMin.Text + ";" + txtvalUnit.Text);

            StreamWriter graProd2 = new StreamWriter(caminho.fullPath + "descProduto.txt", true, Encoding.UTF8);
            graProd2.WriteLine(txtDescProdt.Text);

            graProd1.Close();
            graProd2.Close();

            MessageBox.Show("Salvo com Sucesso!", "Aviso");
        }

        void excluir()
        {
            StreamWriter graProd = new StreamWriter(caminho.fullPath + "produto.txt", false, Encoding.UTF8);

            for (int i = 0; i < totallinha; i++)
            {
                if (i != p)
                {
                    graProd.WriteLine(cadProd[i].codigo + ";" + cadProd[i].descProduto + ";" + cadProd[i].categoria + ";" + cadProd[i].razaoSocial + ";" + cadProd[i].qtdEstoque + ";" + cadProd[i].estMinimo + ";" + cadProd[i].valUnit);
                }
            }

            graProd.Close();

            MessageBox.Show("Excluido com Sucesso!", "Aviso");

        }

        void Atualiza()
        {
            cadProd[p].codigo = txtCod.Text;
            cadProd[p].descProduto = txtDescProdt.Text;
            cadProd[p].categoria = cbxCat.Text;
            cadProd[p].razaoSocial = cbxRazSoc.Text;
            cadProd[p].qtdEstoque = txtQtdEstoque.Text;
            cadProd[p].estMinimo = txtEstoMin.Text;
            cadProd[p].valUnit = txtvalUnit.Text;


        }

        void alterarDados()
        {
            try
            {

                StreamWriter graProd = new StreamWriter(caminho.fullPath + "produto.txt", false, Encoding.UTF8);

                for (int b = 0; b < totallinha; b++)
                {
                    graProd.WriteLine(cadProd[b].codigo + ";" + cadProd[b].descProduto + ";" + cadProd[b].categoria + ";" + cadProd[b].razaoSocial + ";" + cadProd[b].qtdEstoque + ";" + cadProd[b].estMinimo + ";" + cadProd[b].valUnit);
                }

                graProd.Close();

                MessageBox.Show("Alterado com Sucesso!", "Aviso");

                txtCod.Clear();
                txtDescProdt.Clear();
                cbxCat.ResetText();
                cbxRazSoc.ResetText();
                txtQtdEstoque.Clear();
                txtEstoMin.Clear();
                txtCod.Focus();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar salvar dados!", "Aviso");
            }

        }

        void ModoNavegacao()
        {
            btnAlterar.Enabled = (true);
            btnAnt.Enabled = (true);
            btnCancelar.Enabled = (false);
            btnExcluir.Enabled = (true);
            btnNovo.Enabled = (true);
            btnGravar.Enabled = (false);
            btnPrim.Enabled = (true);
            btnProx.Enabled = (true);
            btnUlt.Enabled = (true);
            txtCod.Enabled = (false);
            txtDescProdt.Enabled = (false);
            txtEstoMin.Enabled = (false);
            txtQtdEstoque.Enabled = (false);
            txtvalUnit.Enabled = (false);
            cbxCat.Enabled = (false);
            cbxRazSoc.Enabled = (false);

            this.Text = " - Registro de Fornecedor";
        }

        void ModoEdicao()
        {
            btnAlterar.Enabled = (false);
            btnAnt.Enabled = (false);
            btnCancelar.Enabled = (true);
            btnExcluir.Enabled = (false);
            btnNovo.Enabled = (false);
            btnGravar.Enabled = (true);
            btnPrim.Enabled = (false);
            btnProx.Enabled = (false);
            btnUlt.Enabled = (false);
            txtCod.Enabled = (true);
            txtDescProdt.Enabled = (true);
            txtEstoMin.Enabled = (true);
            txtQtdEstoque.Enabled = (true);
            txtvalUnit.Enabled = (true);
            cbxCat.Enabled = (true);
            cbxRazSoc.Enabled = (true);

            this.Text = this.Text + " - ALTERAÇÃO DO FORNECEDOR";
        }

        void carregarProduto()
        {
            StreamReader graProd = new StreamReader(caminho.fullPath + "produto.txt", Encoding.UTF8);
            string linha = null;

            for (int i = 0; i < totallinha; i++)
            {
                if ((linha = graProd.ReadLine()) != null)
                {
                    string[] vetaux = linha.Split(';');
                    cadProd[i].codigo = vetaux[0];
                    cadProd[i].descProduto = vetaux[1];
                    cadProd[i].categoria = vetaux[2];
                    cadProd[i].razaoSocial = vetaux[3];
                    cadProd[i].qtdEstoque = vetaux[4];
                    cadProd[i].estMinimo = vetaux[5];
                    cadProd[i].valUnit = vetaux[6];
                }
            }
            graProd.Close();
            p = 0;
        }

        void mostrarDados()
        {

            txtCod.Text = Convert.ToString(cadProd[p].codigo);
            txtDescProdt.Text = Convert.ToString(cadProd[p].descProduto);
            cbxCat.Text = Convert.ToString(cadProd[p].categoria);
            cbxRazSoc.Text = Convert.ToString(cadProd[p].razaoSocial);
            txtQtdEstoque.Text = Convert.ToString(cadProd[p].qtdEstoque);
            txtEstoMin.Text = Convert.ToString(cadProd[p].estMinimo);
            txtvalUnit.Text = Convert.ToString(cadProd[p].valUnit);

        }

        void contarlinhas()
        {
            //abrir arquivos
            StreamReader graProd = new StreamReader(caminho.fullPath + "produto.txt", Encoding.UTF8);
            //le a 1 linha 
            string linha = graProd.ReadLine();
            //ler ate o final do arquivo 
            while (linha != null)
            {
                //conta um registro
                totallinha++;
                //ler proxima linha
                linha = graProd.ReadLine();
            }
            //fechar arquivo 
            graProd.Close();
        }

        void carregaCombos()
        {
            try
            {
                //CATEGORIA ARQUIVO TXT
                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader srCat = new StreamReader(caminho.fullPath + "categoria.txt", Encoding.UTF8);

                //Lê a primeira linha do arquivo
                string linhaCat = srCat.ReadLine();

                //Continua lendo até o final do arquivo
                while (linhaCat != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxCat.Items.Add(linhaCat);

                    //Lê a próxima linha
                    linhaCat = srCat.ReadLine();
                }
                //Fecha o arquivo texto
                srCat.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }

            try
            {
                //RAZAO SOCIAL ARQUIVO TXT
                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader srRazSoc = new StreamReader(caminho.fullPath + "razaoSocial.txt", Encoding.UTF8);

                //Lê a primeira linha do arquivo
                string linhaRazSoc = srRazSoc.ReadLine();

                //Continua lendo até o final do arquivo
                while (linhaRazSoc != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxRazSoc.Items.Add(linhaRazSoc);
                    //Lê a próxima linha
                    linhaRazSoc = srRazSoc.ReadLine();
                }
                //Fecha o arquivo texto
                srRazSoc.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }
        }

    }//fim do public partial class produto : Form
}
