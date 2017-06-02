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
    public struct cadCateg
    {
        public string novaCateg;
    }
    public partial class catProdudos : Form
    {
        //caminhgo para fullpath dos arquivos *txt
        configuracao caminho = new configuracao();


        int totallinha = 0;//variavel global
        //numero total de linhas no arquivo texto
        //vetro da minha struct 
        cadPedido[] cadPed; //vetor global da minha estrutura Cadastro
        int p;
        //marcar posição de um registro da struct 

        int modo;
        public catProdudos()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
