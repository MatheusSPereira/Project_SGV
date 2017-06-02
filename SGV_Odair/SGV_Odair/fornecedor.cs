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
    public struct CadForne
    {
        public string codigo;
        public string razaoSocial;
        public string endereco;
        public string cidadeForn;
        public string estadoUF;
        public string cep;
    }
    public partial class fornecedor : Form
    {
        int totallinha = 0;//variavel global
        //numero total de linhas no arquivo texto
        //vetro da minha struct 
        CadForne[] cadForn;  //vetor global da minha estrutura Cadastro
        int p;
        //marcar posição de um registro da struct 
        
        int modo;
        configuracao caminho = new configuracao();
        public fornecedor()
        {
            InitializeComponent();
            
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

        //========== INICIO ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== INICIO ============  

        private void fornecedor_Load(object sender, EventArgs e)
        {
            ModoNavegacao();
            //1. contar numero de linhas do arquivo texto 
            // esse dado sera utilizado posteriormente
            //para inicializar o vetor regaluno
            contarlinhas();

            //defini o tamanho do vetor atraves da função acima 
            cadForn = new CadForne[totallinha];
            //carregar o vetor Cadastro
            carregarFornecedor();
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
            txtRazao.Clear();
            txtEnde.Clear();
            txtCidadeForn.Clear();
            txtCEP.Clear();
            txtCod.Focus();

            modo = 1;
        }

        private void button1_Click(object sender, EventArgs e)
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
            carregarFornecedor();

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
            consFornecedor frmConsFornecedor = new consFornecedor();
            frmConsFornecedor.Show();
        }

        //========== FIM ============ BOTÕES E FORM LOAD IMPLEMENTADOS ========== FIM ============ 


        // ========== INICIO ============ METODOS IMPLEMENTADOS ========== INICIO ============
        void Incluir()
        {
            StreamWriter graForn1 = new StreamWriter(caminho.fullPath + "razaoSocial.txt", true, Encoding.UTF8);

            StreamWriter graForn2 = new StreamWriter(caminho.fullPath + "fornecedor.txt", true, Encoding.UTF8);

            StreamWriter graForn3 = new StreamWriter(caminho.fullPath + "razao&fornecedor.txt", true, Encoding.UTF8);

            graForn1.WriteLine(txtRazao.Text);
            graForn2.WriteLine(txtCidadeForn.Text + ";" + cbxUF.Text);
            graForn3.WriteLine(txtCod.Text + ";" + txtRazao.Text + ";" + txtEnde.Text + ";" + txtCidadeForn.Text + ";" + cbxUF.Text + ";" + txtCEP.Text);

            graForn1.Close();
            graForn2.Close();
            graForn3.Close();

            MessageBox.Show("Salvo com Sucesso!", "Aviso");
        }

        void excluir()
        {
            StreamWriter graForn1 = new StreamWriter(caminho.fullPath + "razaoSocial.txt", false, Encoding.UTF8);

            StreamWriter graForn2 = new StreamWriter(caminho.fullPath + "fornecedor.txt", false, Encoding.UTF8);

            StreamWriter graForn3 = new StreamWriter(caminho.fullPath + "razao&fornecedor.txt", false, Encoding.UTF8);

            for (int i = 0; i < totallinha; i++)
            {
                if (i != p) { 
                    graForn1.WriteLine(cadForn[i].razaoSocial);
                    graForn2.WriteLine(cadForn[i].cidadeForn + ";" + cadForn[i].estadoUF);
                    graForn3.WriteLine(cadForn[i].codigo + ";" + cadForn[i].razaoSocial + ";" + cadForn[i].endereco + ";" + cadForn[i].cidadeForn + ";" + cadForn[i].estadoUF + ";" + cadForn[i].cep);
                }
            }

            graForn1.Close();
            graForn2.Close();
            graForn3.Close();

            MessageBox.Show("Excluido com Sucesso!", "Aviso");

        }

        void Atualiza()
        {
            cadForn[p].codigo = txtCod.Text;
            cadForn[p].razaoSocial = txtRazao.Text;
            cadForn[p].endereco = txtEnde.Text;
            cadForn[p].cidadeForn = txtCidadeForn.Text;
            cadForn[p].estadoUF = cbxUF.Text;
            cadForn[p].cep = txtCEP.Text;

        }

        void alterarDados()
        {
            try
            {
                StreamWriter graForn1 = new StreamWriter(caminho.fullPath + "razaoSocial.txt", false, Encoding.UTF8);

                StreamWriter graForn2 = new StreamWriter(caminho.fullPath + "fornecedor.txt", false, Encoding.UTF8);

                StreamWriter graForn3 = new StreamWriter(caminho.fullPath + "razao&fornecedor.txt", false, Encoding.UTF8);

                for (int b = 0; b < totallinha; b++)
                {
                    graForn1.WriteLine(cadForn[b].razaoSocial);
                    graForn2.WriteLine(cadForn[b].cidadeForn + ";" + cadForn[b].estadoUF);
                    graForn3.WriteLine(cadForn[b].codigo + ";" + cadForn[b].razaoSocial + ";" + cadForn[b].endereco + ";" + cadForn[b].cidadeForn + ";" + cadForn[b].estadoUF + ";" + cadForn[b].cep);

                }

                graForn1.Close();
                graForn2.Close();
                graForn3.Close();

                MessageBox.Show("Alterado com Sucesso!", "Aviso");

                txtCidadeForn.Clear();
                txtRazao.Clear();
                cbxUF.ResetText();
                txtRazao.Focus();
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
            txtCEP.Enabled = (false);
            txtCidadeForn.Enabled = (false);
            txtCod.Enabled = (false);
            txtEnde.Enabled = (false);
            txtRazao.Enabled = (false);
            cbxUF.Enabled = (false);
            this.Text = "Registro de Fornecedor";
        }

        void ModoEdicao()
        {
            btnAlterar.Enabled = (false);
            btnAnt.Enabled = (false);
            btnCancelar.Enabled = (true);
            btnExcluir.Enabled = (true);
            btnNovo.Enabled = (false);
            btnGravar.Enabled = (true);
            btnPrim.Enabled = (false);
            btnProx.Enabled = (false);
            btnUlt.Enabled = (false);
            txtCEP.Enabled = (true);
            txtCidadeForn.Enabled = (true);
            txtCod.Enabled = (true);
            txtEnde.Enabled = (true);
            txtRazao.Enabled = (true);
            cbxUF.Enabled = (true);
            this.Text = this.Text + " - ALTERAÇÃO DO FORNECEDOR";
        }

        void carregarFornecedor()
        {
            StreamReader graForn3 = new StreamReader(caminho.fullPath + "razao&fornecedor.txt", Encoding.UTF8);
            string linha = null;

            for (int i = 0; i < totallinha; i++)
            {
                if ((linha = graForn3.ReadLine()) != null)
                {
                    string[] vetaux = linha.Split(';');
                    cadForn[i].codigo = vetaux[0];
                    cadForn[i].razaoSocial = vetaux[1];
                    cadForn[i].endereco = vetaux[2];
                    cadForn[i].cidadeForn = vetaux[3];
                    cadForn[i].estadoUF = vetaux[4];
                    cadForn[i].cep = vetaux[5];
                }
            }
            graForn3.Close();
            p = 0;
        }

        void mostrarDados()
        {

            txtCod.Text = Convert.ToString(cadForn[p].codigo);
            txtRazao.Text = Convert.ToString(cadForn[p].razaoSocial);
            txtEnde.Text = Convert.ToString(cadForn[p].endereco);
            txtCidadeForn.Text = Convert.ToString(cadForn[p].cidadeForn);
            cbxUF.Text = Convert.ToString(cadForn[p].estadoUF);
            txtCEP.Text = Convert.ToString(cadForn[p].cep);

        }

        void contarlinhas()
        {
            //abrir arquivos
            StreamReader graForn3 = new StreamReader(caminho.fullPath + "razao&fornecedor.txt", Encoding.UTF8);
            //le a 1 linha 
            string linha = graForn3.ReadLine();
            //ler ate o final do arquivo 
            while (linha != null)
            {
                //conta um registro
                totallinha++;
                //ler proxima linha
                linha = graForn3.ReadLine();
            }
            //fechar arquivo 
            graForn3.Close();
        }

        // ========== FIM ============ METODOS IMPLEMENTADOS ========== FIM ============


    }//fim do public partial class fornecedor : Form
}
