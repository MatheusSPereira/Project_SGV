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

namespace SGV_Odair
{
    public partial class caminhoDados : Form
    {
        public caminhoDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                
                //Instancio o FolderBrowserDialog e o chamo pelo método ShowDialog

                FolderBrowserDialog objFBD = new FolderBrowserDialog();

                //Chamo o método sss para que esteja habilitado o botão para criar uma nova pasta

                objFBD.ShowNewFolderButton = true;

                objFBD.ShowDialog();

                //Crio uma variável que irei definir o caminho onde vou salvar meu arquivo de texto

                //Ela irá receber meu objFBD com o método SelectedPath, concatenado com meu arquivo

               string strPath = objFBD.SelectedPath + @"\Arquivo.txt";

                //Usarei a cláusula using como boas práticas de programação em todos os métodos

                //Instancio a classe FileStream, uso a classe File e o método Create para criar o

                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo

                //Troco a variável strPathFile pela strPath, que está definindo o caminho do meu arquivo

                using (FileStream fs = File.Create(strPath))

                {

                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)

                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente

                    using (StreamWriter sw = new StreamWriter(fs))

                    {

                        //Uso o método Write para escrever algo em nosso arquivo texto

                        sw.Write("Texto adicionado ao exemplo!");

                    }

                }

            }

            catch (Exception ex)

            {
                //Se tudo ocorrer bem, exibo a mensagem ao usuário.
                MessageBox.Show(ex.Message);

            }

           

            MessageBox.Show("Arquivo criado com sucesso!!!");
            Principal frmPrincipal = new Principal();
            frmPrincipal.Show();


            
        }


        
    }

 }
