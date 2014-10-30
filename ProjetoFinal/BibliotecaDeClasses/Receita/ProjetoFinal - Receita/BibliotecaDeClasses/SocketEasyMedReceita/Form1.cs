using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using BibliotecaDeClasses;

namespace SocketEasyMedReceita
{
    public partial class FormValidaReceita : Form
    {
        private Socket socket;
        private Thread thread;


        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;

        TcpListener tcpListener;
        
       
        public FormValidaReceita()
        {
            InitializeComponent();
            btFinalizarReceita.Enabled = false;
            comboBox1.Enabled = false;
            thread = new Thread(new ThreadStart(ServerReceita));
            thread.Start();
            

        }

        

        private void AddToListBox(object oo)
        {
            Invoke(new MethodInvoker(
                           delegate { listBox1.Items.Add(oo.ToString()); }
                           ));
        }

        public void ServerReceita()
        {

            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("172.16.2.7"), 2001);
                tcpListener = new TcpListener(ipEndPoint);
                tcpListener.Start();

              //  AddToListBox("Servidor habilitado...");

                socket = tcpListener.AcceptSocket();
                networkStream = new NetworkStream(socket);
                binaryWriter = new BinaryWriter(networkStream);
                binaryReader = new BinaryReader(networkStream);

              // AddToListBox("conexão recebida!" + "Server App");
              // binaryWriter.Write("\nconexão efetuada!");

               

                string messageReceived = "";
                do
                {
                    Conexao conexao = new Conexao();
                    conexao.abrirConexao();
                    //List<Receita> lista = conexao.ListarReceita();

                    messageReceived = binaryReader.ReadString();
                    AddToListBox(messageReceived);
                    
       

                    //MessageBox.Show("Mensagem do cliente: " + messageReceived, "Server App");
                    #region
                    /* Conexao con = new Conexao();
                    con.abrirConexao();
                    List<Receita> lista = con.select(Int32.Parse(messageReceived));
                   
                        foreach (var item in lista)
                        {
                            //Inserindo os registros no datagrid
                            string[] row = new string[] { item.Medico.ToString(), item.Paciente.ToString(), item.Status };

                            
                            
                        }              
                     
                    */
                    #endregion
                } while (socket.Connected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (binaryReader != null)
                {
                    binaryReader.Close();
                }
                if (binaryWriter != null)
                {
                    binaryWriter.Close();
                }
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (socket != null)
                {
                    socket.Close();
                }
                MessageBox.Show("conexão finalizada", "Server App");

            }
        }




        

        private void btFinalizarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();


                string idReceita = listBox1.SelectedItem.ToString();

                

                    conexao.atualizarStatus(Int32.Parse(idReceita), comboBox1.SelectedItem.ToString());


                    MessageBox.Show("Receita validada com sucesso");
                

            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione o Número da Receita");
            }
            else
            {

                
                comboBox1.Enabled = true;
                btFinalizarReceita.Enabled = true;
                btSelecionarPaciente.Enabled = false;
                listBox1.Items.Remove(0);
            }
            
            
        }

        //Evento click do ListBox
        private void listBox1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                string idReceita = listBox1.SelectedItem.ToString();

             List<Receita> lista = conexao.select(Int32.Parse(idReceita));

             foreach (var item in lista)
             {
                 lbResultadoMedico.Text = item.Medico.Nome;
                 lbResultadoPaciente.Text = item.Paciente.Nome;
             }
            }
            catch (NullReferenceException nulo)
            {
                MessageBox.Show("Não encontramos nenhuma receita no momento");
            }
        }

        
    }
}
