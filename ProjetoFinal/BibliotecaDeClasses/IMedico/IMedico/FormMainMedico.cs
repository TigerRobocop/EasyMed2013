using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostConsulta;


//oficial
namespace IMedico
{
    public partial class FormMainMedico : Form
    {
        Consulta novaConsulta;
        Medico medico;
        Paciente paciente;

        //FormConsultarPacienteMedico formFilho;

        public FormMainMedico(Medico login)
        {
            InitializeComponent();
            medico = new Medico();
            medico = login;

            MessageBox.Show("Bem vindo, " + medico.Nome + "!", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Text += " - " + medico.Nome;

        }

        private void btConsultaPaciente_Click(object sender, EventArgs e)
        {
            new FormConsultarPacienteMedico(novaConsulta, medico, this).ShowDialog();
        }

        private void btFormGerarParecer_Click(object sender, EventArgs e)
        {
            if (novaConsulta == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                new FormGerarParecer(this.novaConsulta, this).ShowDialog();
            }

        }


        //métodos acionados na tela de pesquisar paciente
        public void loadConsulta(Consulta c)
        {
            novaConsulta = new Consulta();

            this.novaConsulta = c;
            this.paciente = novaConsulta.Paciente;
            this.novaConsulta.Medico = medico;

            //carrega os dados do paciente vindo da triagem na tela principal
            gbDadosPaciente.Text = "Dados do Paciente - Prontuário número: " + c.NumeroProntuario.ToString();
            lblNomePaciente.Text = "Nome: " + novaConsulta.Paciente.Nome;
            lblDataNascimento.Text = "Data de nascimento: " + novaConsulta.Paciente.DataNascimento.ToShortDateString();
            lblNomeMae.Text = "Nome da Mãe: " + novaConsulta.Paciente.NomeMae;
            lblNomePai.Text = "Nome do Pai: " + novaConsulta.Paciente.NomePai;
            lblSexo.Text = "Sexo : " + novaConsulta.Paciente.Sexo;

            lblTemperatura.Text = "Temperatura: " + novaConsulta.DadosVitais.Temperatura + "°C";
            lblPulso.Text = "Pulso: " + novaConsulta.DadosVitais.Pulso + "bpm";
            lblRespiracao.Text = "Respiração: " + novaConsulta.DadosVitais.Respiracao + "rpm";
            lblPressão.Text = "Pressão: " + novaConsulta.DadosVitais.Pressao;
            lblObservações.Text = "Observações: " + novaConsulta.Observacoes;
            lblEnfermeiro.Text = "Enfermeiro: " + novaConsulta.Enfermeiro.Nome;

        }


        //só muda o nome do botão de escolher paciente - a funcionalidade é a mesma de antes
        public void btnAlterarNome()
        {
            btFormConsultaPaciente.Text = "Alterar Paciente da Consulta";
        }

        private void btnFormPesquisarHistorico_Click(object sender, EventArgs e)
        {
            if (this.paciente == null)
            {
                MessageBox.Show("Selecione um Paciente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                new FormHistorico(this.novaConsulta).ShowDialog();
            }

        }



    }
}
