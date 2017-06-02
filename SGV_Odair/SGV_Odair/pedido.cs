using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGV_Odair;

namespace SGV_Odair
{
    public struct validaEntSai
    {
        public string codigo;
        public string descProduto;
        public string categoria;
        public string razaoSocial;
        public string qtdEstoque;
        public string estMinimo;
        public string valUnit;

    }

    public struct cadPedido
    {
        public string codigo;
        public string dataPedido;
        public string descPedido;
        public string tipoMovi;
        public string qtdMovi;

    }

    public partial class pedido : Form
    {
        //caminhgo para fullpath dos arquivos *txt
        configuracao caminho = new configuracao();


        int totallinha = 0;//variavel global
        int totLinhaProduto = 0;
        //numero total de linhas no arquivo texto
        //vetro da minha struct 
        validaEntSai[] valida;
        cadPedido[] cadPed; //vetor global da minha estrutura Cadastro
        int p;
        //marcar posição de um registro da struct 

        int modo;

        public pedido()
        {
            InitializeComponent();

            carregaCombos();
        }

        //========== INICIO ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== INICIO ============ 
        private void pedido_Load(object sender, EventArgs e)
        {
            ModoNavegacao();
            //1. contar numero de linhas do arquivo texto 
            // esse dado sera utilizado posteriormente
            //para inicializar o vetor regaluno
            contarlinhas();
            //defini o tamanho do vetor atraves da função acima 
            cadPed = new cadPedido[totallinha];
            valida = new validaEntSai[totLinhaProduto];
            //carregar o vetor Cadastro
           // carregarProduto();
            carregarPedido();
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

            txtCodPed.Clear();
            txtDataPed.Clear();
            txtQtdMov.Clear();

            txtCodPed.Focus();

            modo = 1;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (modo == 1)//modo == 1 é para adicionar um novo registro
            {
                Incluir();
                //carregarFornecedor();
                //Atualiza();
                carregarPedido();
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
            carregarPedido();
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
            consCategoria frmConsCategoria = new consCategoria();
            frmConsCategoria.Show();
        }
        //========== FIM ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== FIM ============


        void Incluir()
        {
            int qtdEstoquenew = 0;
       

            StreamReader validaProd = new StreamReader(caminho.fullPath + "produto.txt", Encoding.UTF8);
            string linhaProduto = null;

            for (int i = 0; i < totLinhaProduto; i++)
            {
                if ((linhaProduto = validaProd.ReadLine()) != null)
                {
                    string[] vetaux = linhaProduto.Split(';');
                    valida[i].codigo = vetaux[0];
                    valida[i].descProduto = vetaux[1];
                    valida[i].categoria = vetaux[2];
                    valida[i].razaoSocial = vetaux[3];
                    valida[i].qtdEstoque = vetaux[4];
                    valida[i].estMinimo = vetaux[5];
                    valida[i].valUnit = vetaux[6];

                    qtdEstoquenew = int.Parse(valida[i].qtdEstoque = vetaux[4]);

                    //===================== IF DO "E" =====================
                    if (cbxTipMov.Text == "E")
                    {

                        if (Convert.ToString(valida[i].descProduto = vetaux[1]) == Convert.ToString(cbxDescProdut.Text))
                        {
                            qtdEstoquenew = int.Parse(valida[i].qtdEstoque) + int.Parse(txtQtdMov.Text);

                            //qtdEstoque = result;
                            validaProd.Close();

                            //MessageBox.Show("E2" + "\n" + qtdEstoquenew);
                           // validaProd.Close();
                        }
                        //MessageBox.Show("E");

                        StreamWriter graProd = new StreamWriter(caminho.fullPath + "produto2.txt", false, Encoding.UTF8);

                        for (int b = 0; b < totLinhaProduto; b++)
                        {
                            graProd.WriteLine(valida[b].codigo + ";" + valida[b].descProduto + ";" + valida[b].categoria + ";" + valida[b].razaoSocial + ";" + qtdEstoquenew + ";" + valida[b].estMinimo + ";" + valida[b].valUnit);
                        }

                        graProd.Close();

                    }//fim do if == "E"



                    //===================== IF DO "S" =====================
                    if (cbxTipMov.Text == "S")
                    {

                        if (Convert.ToString(valida[i].descProduto = vetaux[1]) == Convert.ToString(cbxDescProdut.Text))
                        {
                            qtdEstoquenew =  int.Parse(valida[i].qtdEstoque) - int.Parse(txtQtdMov.Text);


                            validaProd.Close();

                            //MessageBox.Show("S2" + "\n" + qtdEstoquenew);
                           
                        }
                       // MessageBox.Show("S");

                        StreamWriter graProd = new StreamWriter(caminho.fullPath + "produto2.txt", false, Encoding.UTF8);

                        for (int i2 = 0; i2 < totLinhaProduto; i2++)
                            //{
                            graProd.WriteLine(valida[i2].codigo + ";" + valida[i2].descProduto + ";" + valida[i2].categoria + ";" + valida[i2].razaoSocial + ";" + qtdEstoquenew + ";" + valida[i2].estMinimo + ";" + valida[i2].valUnit);
                        //}

                        graProd.Close();

                    }//fim do if == "S"
                }
            }
            validaProd.Close();
            p = 0;

            StreamWriter graPedi = new StreamWriter(caminho.fullPath + "pedido.txt", true, Encoding.UTF8);
            graPedi.WriteLine(txtCodPed.Text + ";" + txtDataPed.Text + ";" + cbxDescProdut.Text + ";" + cbxTipMov.Text + ";" + txtQtdMov.Text);
            graPedi.Close();


            MessageBox.Show("Salvo com Sucesso!", "Aviso");

        }

        void excluir()
        {
            StreamWriter graPedi = new StreamWriter(caminho.fullPath + "pedido.txt", false, Encoding.UTF8);

            for (int i = 0; i < totallinha; i++)
            {
                if (i != p)
                {
                    graPedi.WriteLine(cadPed[i].codigo + ";" + cadPed[i].dataPedido + ";" + cadPed[i].descPedido + ";" + cadPed[i].tipoMovi + ";" + cadPed[i].qtdMovi);
                }
            }

            graPedi.Close();

            MessageBox.Show("Excluido com Sucesso!", "Aviso");

        }

        void Atualiza()
        {
            cadPed[p].codigo = txtCodPed.Text;
            cadPed[p].dataPedido = txtDataPed.Text;
            cadPed[p].descPedido = cbxDescProdut.Text;
            cadPed[p].tipoMovi = cbxTipMov.Text;
            cadPed[p].qtdMovi = txtQtdMov.Text;
        }

        void alterarDados()
        {
            try
            {

                StreamWriter graPedido = new StreamWriter(caminho.fullPath + "pedido.txt", false, Encoding.UTF8);

                for (int b = 0; b < totallinha; b++)
                {
                    graPedido.WriteLine(cadPed[b].codigo + ";" + cadPed[b].dataPedido + ";" + cadPed[b].descPedido + ";" + cadPed[b].tipoMovi + ";" + cadPed[b].qtdMovi);
                }

                graPedido.Close();

                MessageBox.Show("Alterado com Sucesso!", "Aviso");

                txtCodPed.Clear();
                txtDataPed.Clear();
                txtQtdMov.Clear();

                txtCodPed.Focus();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar alterar dados!", "Aviso");
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
            txtCodPed.Enabled = (false);
            txtDataPed.Enabled = (false);
            cbxDescProdut.Enabled = (false);
            cbxTipMov.Enabled = (false);
            txtQtdMov.Enabled = (false);

            this.Text = this.Text + "Registro de Fornecedor";
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
            txtCodPed.Enabled = (true);
            txtDataPed.Enabled = (true);
            cbxDescProdut.Enabled = (true);
            cbxTipMov.Enabled = (true);
            txtQtdMov.Enabled = (true);

            this.Text = this.Text + " - ALTERAÇÃO DO Pedido";
        }

        void carregarPedido()
        {

           // contarlinhas();

            StreamReader graPedido = new StreamReader(caminho.fullPath + "pedido.txt", Encoding.UTF8);
            string linha = null;

           // cadPed = new cadPedido[totallinha];

            for (int i = 0; i < totallinha; i++)
            {
                if ((linha = graPedido.ReadLine()) != null)
                {
                    string[] vetaux = linha.Split(';');
                    cadPed[i].codigo = vetaux[0];
                    cadPed[i].dataPedido = vetaux[1];
                    cadPed[i].descPedido = vetaux[2];
                    cadPed[i].tipoMovi = vetaux[3];
                    cadPed[i].qtdMovi = vetaux[4];

                }
            }
            graPedido.Close();
            p = 0;
        }

        void mostrarDados()
        {
            txtCodPed.Text = Convert.ToString(cadPed[p].codigo);
            txtDataPed.Text = Convert.ToString(cadPed[p].dataPedido);
            cbxDescProdut.Text = Convert.ToString(cadPed[p].descPedido);
            cbxTipMov.Text = Convert.ToString(cadPed[p].tipoMovi);
            txtQtdMov.Text = Convert.ToString(cadPed[p].qtdMovi);

        }

        void contarlinhas()
        {
            //abrir arquivos
            StreamReader graPedido = new StreamReader(caminho.fullPath + "pedido.txt", Encoding.UTF8);
            StreamReader graProdut = new StreamReader(caminho.fullPath + "produto.txt", Encoding.UTF8);
            //le a 1 linha 
            string linha = graPedido.ReadLine();
            string linhaProduto = graProdut.ReadLine();
            //ler ate o final do arquivo 
            while (linha != null && linhaProduto != null)
            {
                //conta um registro
                totallinha++;
                totLinhaProduto++;
                //ler proxima linha
                linha = graPedido.ReadLine();
                linhaProduto = graProdut.ReadLine();
            }
            //fechar arquivo 
            graPedido.Close();
            graProdut.Close();
        }

        void carregaCombos()
        {
            try
            {
                //CATEGORIA ARQUIVO TXT
                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader srDescProduto = new StreamReader(caminho.fullPath + "descProduto.txt", Encoding.UTF8);

                //Lê a primeira linha do arquivo
                string linhaDescProduto = srDescProduto.ReadLine();

                //Continua lendo até o final do arquivo
                while (linhaDescProduto != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxDescProdut.Items.Add(linhaDescProduto);

                    //Lê a próxima linha
                    linhaDescProduto = srDescProduto.ReadLine();
                }
                //Fecha o arquivo texto
                srDescProduto.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }


            try
            {
                //RAZAO SOCIAL ARQUIVO TXT
                //Inicializa o construtor StreamReader com o nome do arquivo e define que //utilizará acentuação
                StreamReader srTipoMov = new StreamReader(caminho.fullPath + "tipoMovimento.txt", Encoding.UTF8);

                //Lê a primeira linha do arquivo
                string linhaTipoMovi = srTipoMov.ReadLine();

                //Continua lendo até o final do arquivo
                while (linhaTipoMovi != null)
                {
                    //Adiciona o linha lida no ListBox
                    cbxTipMov.Items.Add(linhaTipoMovi);
                    //Lê a próxima linha
                    linhaTipoMovi = srTipoMov.ReadLine();
                }
                //Fecha o arquivo texto
                srTipoMov.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao tentar abrir o arquivo!", "Aviso");
            }


        }


        void carregarProduto()
        {

            StreamReader validaProd = new StreamReader(caminho.fullPath + "produto.txt", Encoding.UTF8);
            string linhaProduto = null;

            for (int i = 0; i < totLinhaProduto; i++)
            {
                if ((linhaProduto = validaProd.ReadLine()) != null)
                {
                    string[] vetaux = linhaProduto.Split(';');
                    valida[i].codigo = vetaux[0];
                    valida[i].descProduto = vetaux[1];
                    valida[i].categoria = vetaux[2];
                    valida[i].razaoSocial = vetaux[3];
                    valida[i].qtdEstoque = vetaux[4];
                    valida[i].estMinimo = vetaux[5];
                    valida[i].valUnit = vetaux[6];
                }
            }
            validaProd.Close();
            p = 0;

            MessageBox.Show("Produtos Carregado com Sucesso!", "Aviso");

        }

        
        
    }
}


