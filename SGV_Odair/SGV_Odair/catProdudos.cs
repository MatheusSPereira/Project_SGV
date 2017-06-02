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

namespace SGV_Odair
{
    public struct cadCateg
    {
        public string novaCateg;
        public string descCateg;
    }
    public partial class catProdudos : Form
    {
        //caminhgo para fullpath dos arquivos *txt
        configuracao caminho = new configuracao();

        //variavel global
        int totallinha = 0;
        int totalLinha = 0;
        //numero total de linhas no arquivo texto
        //vetro da minha struct 
        cadCateg[] cadCat; //vetor global da minha estrutura Cadastro
        int p;
        //marcar posição de um registro da struct 

        int modo;
        public catProdudos()
        {
            InitializeComponent();
        }

        private void catProdudos_Load(object sender, EventArgs e)
        {
            ModoNavegacao();
            //1. contar numero de linhas do arquivo texto 
            // esse dado sera utilizado posteriormente
            //para inicializar o vetor regaluno
            contarlinhas();
            //defini o tamanho do vetor atraves da função acima 
            cadCat = new cadCateg[totallinha];
            //carregar o vetor Cadastro

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

        private void btnPrim_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p = 0;
            mostrarDados();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            ModoNavegacao();
            p = totallinha - 1;
            mostrarDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoEdicao();

            txtCatProdut.Clear();
            txtdescCateg.Clear();

            txtCatProdut.Focus();

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
            consCategoria frmconsCat = new consCategoria();
            frmconsCat.Show();
        }


        void Incluir()
        {

            StreamWriter graCat = new StreamWriter(caminho.fullPath + "categoria.txt", true, Encoding.UTF8);
            graCat.WriteLine(txtCatProdut.Text);
            graCat.Close();

            StreamWriter graDescCat = new StreamWriter(caminho.fullPath + "descCateg.txt", true, Encoding.UTF8);
            graDescCat.WriteLine(txtdescCateg.Text);
            graDescCat.Close();

            StreamWriter graDescECat = new StreamWriter(caminho.fullPath + "categ&desc.txt", true, Encoding.UTF8);
            graDescECat.WriteLine(txtCatProdut.Text + ";" + txtdescCateg.Text);
            graDescECat.Close();


            MessageBox.Show("Salvo com Sucesso!", "Aviso");
        }

        void excluir()
        {
            StreamWriter graCat = new StreamWriter(caminho.fullPath + "categoria.txt", false, Encoding.UTF8);

            for (int i = 0; i < totallinha; i++)
            {
                if (i != p)
                {
                    graCat.WriteLine(cadCat[i].novaCateg);
                }
            }

            graCat.Close();


            StreamWriter graDescCat = new StreamWriter(caminho.fullPath + "descCateg.txt", false, Encoding.UTF8);

            for (int i = 0; i < totallinha; i++)
            {
                if (i != p)
                {
                    graDescCat.WriteLine(cadCat[i].descCateg);
                }
            }

            graDescCat.Close();

            MessageBox.Show("Excluido com Sucesso!", "Aviso");

        }

        void Atualiza()
        {
            cadCat[p].novaCateg = txtCatProdut.Text;
            cadCat[p].descCateg = txtdescCateg.Text;
        }

        void alterarDados()
        {
            try
            {

                StreamWriter graCat = new StreamWriter(caminho.fullPath + "categoria.txt", false, Encoding.UTF8);

                for (int b = 0; b < totallinha; b++)
                {
                    graCat.WriteLine(cadCat[b].novaCateg);
                }

                graCat.Close();

                StreamWriter graDescCat = new StreamWriter(caminho.fullPath + "descCateg.txt", false, Encoding.UTF8);

                for (int b = 0; b < totallinha; b++)
                {
                    graDescCat.WriteLine(cadCat[b].descCateg);
                }

                graDescCat.Close();

                MessageBox.Show("Alterado com Sucesso!", "Aviso");

                txtCatProdut.Clear();
                txtdescCateg.Clear();

                txtCatProdut.Focus();
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
            txtCatProdut.Enabled = (false);
            txtdescCateg.Enabled = (false);


            this.Text = this.Text + "Registro da Nova Categoria";
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
            txtCatProdut.Enabled = (true);
            txtdescCateg.Enabled = (true);


            this.Text = this.Text + " - Alteração da Categoria";
        }

        void carregarPedido()
        {

            // contarlinhas();

            StreamReader graCat = new StreamReader(caminho.fullPath + "categoria.txt", Encoding.UTF8);
            string linha = null;

            // cadPed = new cadPedido[totallinha];

            for (int i = 0; i < totallinha; i++)
            {
                if ((linha = graCat.ReadLine()) != null)
                {
                    string[] vetaux = linha.Split(';');
                    cadCat[i].novaCateg = vetaux[0];

                }
            }
            graCat.Close();
            p = 0;

            StreamReader graDescCat = new StreamReader(caminho.fullPath + "descCateg.txt", Encoding.UTF8);
            string linhaDescCat = null;

            // cadPed = new cadPedido[totallinha];

            for (int i = 0; i < totallinha; i++)
            {
                if ((linhaDescCat = graDescCat.ReadLine()) != null)
                {
                    string[] vetaux = linhaDescCat.Split(';');
                    cadCat[i].descCateg = vetaux[0];

                }
            }
            graDescCat.Close();
            p = 0;
        }

        void mostrarDados()
        {
            txtCatProdut.Text = Convert.ToString(cadCat[p].novaCateg);
            txtdescCateg.Text = Convert.ToString(cadCat[p].descCateg);
            
        }

        void contarlinhas()
        {
            //abrir arquivos
            StreamReader graCat = new StreamReader(caminho.fullPath + "categoria.txt", Encoding.UTF8);
            StreamReader graDescCat = new StreamReader(caminho.fullPath + "descCateg.txt", Encoding.UTF8);
            //le a 1 linha 
            string linhaCat = graCat.ReadLine();
            string linhaDesCat = graDescCat.ReadLine();
            //ler ate o final do arquivo 
            while (linhaCat != null && linhaDesCat != null)
            {
                //conta um registro
                totallinha++;
                totalLinha++;
                //ler proxima linha
                linhaCat = graCat.ReadLine();
                linhaDesCat = graDescCat.ReadLine();
            }
            //fechar arquivo 
            graCat.Close();
            graDescCat.Close();
        }







    }
}
