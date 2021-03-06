﻿using System;
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
    public partial class consProduto : Form
    {
        configuracao caminho = new configuracao();


        public consProduto()
        {
            InitializeComponent();
        }

        private void consProduto_Load(object sender, EventArgs e)
        {
            MostraDados();
            
        }


        private void MostraDados()
        {
             
            // Create an unbound DataGridView by declaring a column count.
            gridConsProduto.ColumnCount = 7;
            gridConsProduto.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            // Define o cabeçalho das colunas da grid
            gridConsProduto.Columns[0].Name = "Código";
            gridConsProduto.Columns[1].Name = "Descr. Produto";
            gridConsProduto.Columns[2].Name = "Categoria";
            gridConsProduto.Columns[3].Name = "Razão Social";
            gridConsProduto.Columns[4].Name = "Qtd Estoque";
            gridConsProduto.Columns[5].Name = "Estoque Minimo";
            gridConsProduto.Columns[6].Name = "Valor Minimo";

            //Criando um DataTable
            //DataTable dt = new DataTable();

            //Lendo Todas as linhas do arquivo CSV
            //string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "razaoSocial.txt + fornecedor.txt" + "");
            string[] Linha = System.IO.File.ReadAllLines(caminho.fullPath + "produto.txt");

            DataGridViewRowCollection rows = this.gridConsProduto.Rows;

            //Neste For, vamos percorrer todas as linhas que foram lidas do arquivo CSV
            for (int i = 0; i < Linha.Length; i++)
            {
                //Aqui Estamos pegando a linha atual, e separando os campos
                //Por exemplo, ele vai lendo um texto, e quando achar um ponto e virgula
                //ele pega o texto e joga na outra posição do array temp, e assim por diante
                //até chegar no final da linha
                string[] campos = Linha[i].Split(Convert.ToChar(";"));
                rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6]);

                
                RowsColor();


            }


        }

         public void RowsColor()
        {

            for (int i = 0; i < gridConsProduto.Rows.Count; i++)
            {
                int qtdEstoque = int.Parse(gridConsProduto.Rows[i].Cells[4].Value.ToString());
                int estoqMin = int.Parse(gridConsProduto.Rows[i].Cells[5].Value.ToString());


                if (qtdEstoque < estoqMin)
                {
                    gridConsProduto.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

    }
}