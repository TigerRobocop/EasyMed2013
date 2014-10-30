using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostReceita;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace IMedico
{
    public partial class FormGerarReceita : Form
    {
        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;
        private TcpClient tcpClient;

        private Thread thread;

        Medicamento[] ListaMedicamento;

        int CodigoMedico;
        int CodigoPaciente;
        public FormGerarReceita(int codMedico, int codPaciente)
        {
            
            InitializeComponent();
            CodigoMedico = codMedico;
            CodigoPaciente = codPaciente;
            //para o socket
            thread = new Thread(new ThreadStart(Cliente));
            thread.Start();
        }

        public FormGerarReceita(BinaryWriter binaryWriter)
        {
            this.binaryWriter = binaryWriter;
        }

     
        
       
        public void Cliente()
        {
            try
            {
                tcpClient = new TcpClient();
                //conectando ao servidor
                tcpClient.Connect("172.16.3.8", 2001);

                networkStream = tcpClient.GetStream();
                binaryWriter = new BinaryWriter(networkStream);
                binaryReader = new BinaryReader(networkStream);

                String message = "";

                #region laço para receber mensagem do servidor
                do
                {
                    try
                    {
                        message = binaryReader.ReadString();
                        MessageBox.Show(message, "Mensagem Recebida do servidor");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                        message = "FIM";
                    }
                } while (message != "FIM");
                #endregion

                binaryWriter.Close();
                binaryReader.Close();
                networkStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void btAdicionarMedicamento_Click(object sender, EventArgs e)
        {
            if (txtBoxQuantidade.Text == "" && txtBoxDosagem.Text == "" && txtBoxTempoTratamento.Text == "" && txtBoxInstrucoes.Text == "")
            {
                MessageBox.Show("Favor Inserir Corretamente todos os campos do Medicamento!", "Confirmação de Campos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            else
            {

                ListViewItem item = lvListaMedicamentosRetorno.SelectedItems[0];

                ListViewItem medicamento = new ListViewItem();
                medicamento.Text = item.Text;

                medicamento.SubItems.Add(txtBoxQuantidade.Text);
                medicamento.SubItems.Add(txtBoxDosagem.Text);
                medicamento.SubItems.Add(txtBoxTempoTratamento.Text);
                medicamento.SubItems.Add(txtBoxInstrucoes.Text);

                lvReceitaParcial.Items.Add(medicamento);
                lblTipo.Text = "Tipo: ";
                lblNomeGenerico.Text = "Nome Genérico: ";
                lblNomeComercial.Text = "Nome Comercial: ";
                lblComposicao.Text = "Composição: ";
                lblDosagem.Text = "Dosagem: ";
                lblContraIndicacoes.Text = "Contra-indicações: ";
                lblIndicacoes.Text = "Indicações: ";
                lblFabricante.Text = "Fabricante: ";
                txtBoxQuantidade.Text = "";
                txtBoxDosagem.Text = "";
                txtBoxTempoTratamento.Text = "";
                txtBoxInstrucoes.Text = "";

            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            lvListaMedicamentosRetorno.Items.Clear();
            ServicoReceita sr = new ServicoReceita();
            Medicamento m = new Medicamento();
            m.Tipo = txtBoxCategoria.Text;
            m.NomeComercial = txtBoxNomeComercial.Text;
            m.NomeGenerico = txtBoxNomeGenerico.Text;
            this.ListaMedicamento = sr.ListarMedicamentos(m);

            foreach (var item in ListaMedicamento)
            {
                ListViewItem medicamento = new ListViewItem();

                medicamento.Text = item.Codigo.ToString();
                medicamento.SubItems.Add(item.Tipo);
                medicamento.SubItems.Add(item.NomeGenerico);
                medicamento.SubItems.Add(item.NomeComercial);
                medicamento.SubItems.Add(item.Composicao);
                medicamento.SubItems.Add(item.Dosagem);
                medicamento.SubItems.Add(item.Indicacoes);
                medicamento.SubItems.Add(item.ContraIndicacoes);
                medicamento.SubItems.Add(item.Fabricante);

                lvListaMedicamentosRetorno.Items.Add(medicamento);
            }
        }

        private void lvListaMedicamentosRetorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListaMedicamentosRetorno.SelectedItems.Count > 0)
            {
                ListViewItem item = lvListaMedicamentosRetorno.SelectedItems[0];

                lblTipo.Text = "Tipo: " + item.SubItems[1].Text;
                lblNomeGenerico.Text = "Nome Genérico: " + item.SubItems[2].Text;
                lblNomeComercial.Text = "Nome Comercial: " + item.SubItems[3].Text;
                lblComposicao.Text = "Composição: " + item.SubItems[4].Text;
                lblDosagem.Text = "Dosagem: " + item.SubItems[5].Text;
                lblIndicacoes.Text = "Indicações: " + item.SubItems[6].Text;
                lblContraIndicacoes.Text = "Contra Indicações: " + item.SubItems[7].Text;
                lblFabricante.Text = "Fabricante: " + item.SubItems[8].Text;

            }
        }

        private void lbListaMedicamentosReceita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvReceitaParcial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btGerarReceita_Click(object sender, EventArgs e)
        {
            

            if (lvReceitaParcial.Items.Count == 0)
            {
                MessageBox.Show("Favor Inserir ao menos um Medicamento Válido!", "Confirmação de Medicamento",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                // dizer pro cara inserir pelo menos um medicamento
                
            }
              
            else {

                Receita receita = new Receita();
                ReceitaMedicamento[] listaMedicamentos = new ReceitaMedicamento[lvReceitaParcial.Items.Count];
                receita.ListaMedicamentos = listaMedicamentos;
                ServicoReceita svc = new ServicoReceita();

                receita.Medico = new Medico() { Id = CodigoMedico };
                receita.Paciente = new Paciente() { Id = CodigoPaciente };

                
                
                for (int i = 0; i < lvReceitaParcial.Items.Count ; i++)
                {

                    ListViewItem item = lvReceitaParcial.Items[i];

                    ReceitaMedicamento med = new ReceitaMedicamento();


                    int codigo = Convert.ToInt32(item.Text);

                     med.Dosagem = item.SubItems[1].Text;
                     med.Quantidade = item.SubItems[2].Text;
                     med.TempoTratamento = item.SubItems[3].Text;
                     med.Instrucoes = item.SubItems[4].Text;
                     med.Medicamento = new Medicamento() { Codigo = codigo};

                     receita.ListaMedicamentos[i] = med;
                    
                }
                /**
                 * Pega o numero da receita gerada e envia para o socket
                 * */
                int numeroReceita = svc.CadastrarReceita(receita);
                
                binaryWriter.Write(numeroReceita.ToString());
                
                MessageBox.Show("Receita Cadastrada com Sucesso!.", "Inclusão de Receita",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(receita.Numero.ToString(), "Inclusão de Receita",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

                 //MessageBox.Show("Receita Cadastrada!");
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (lvReceitaParcial.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor Selecionar ao menos um Medicamento Válido antes de Excluir!", "Confirmação de Exclusão Medicamento",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

                // voce deve selecionar pelo menos um medicamento a ser excluido
            }
            else {
                lvReceitaParcial.SelectedItems[0].Remove();
            
            }
        }



        /*
         
         * 
         * 
         * 
         * 
         */




    }
}
