using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostConsulta;

namespace IMedico
{
    public partial class FormGerarParecer : Form
    {        
        Consulta consultaAtual;
        Receita receitaConsulta;
        FormMainMedico formPai;
        
                
        public FormGerarParecer(Consulta c, FormMainMedico formPai)
        {
            InitializeComponent();

            this.formPai = formPai;
            this.consultaAtual = c;

            //load dados do paciente nas labels
            gbDadosPaciente.Text = "Dados do Paciente - Prontuário número: " + consultaAtual.NumeroProntuario.ToString();
            lblNomePaciente.Text = "Nome: " + consultaAtual.Paciente.Nome;
            lblDataNascimento.Text = "Data de nascimento: " + consultaAtual.Paciente.DataNascimento.ToShortDateString();
            lblNomeMae.Text = "Nome da Mãe: " + consultaAtual.Paciente.NomeMae;
            lblNomePai.Text = "Nome do Pai: " + consultaAtual.Paciente.NomePai;
            lblSexo.Text = "Sexo : " + consultaAtual.Paciente.Sexo;

            //load dados do médico nas labels
            gbDadosMedico.Text += " " + c.Medico.Id.ToString();
            lblNomeMedico.Text += " " + c.Medico.Nome;
            lblCRM.Text += " " + c.Medico.Crm.ToString();
            lblEspecializacao.Text += " " + c.Medico.Especializacao;

        }

        private void btFormGerarAtestado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOOOOPPPPSS!!!!", "NO GOOD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new FormGerarAtestado().ShowDialog();
        }

        private void btFormGerarReceita_Click(object sender, EventArgs e)
        {
            int codigoMedico = consultaAtual.Medico.Id;
            int codigoPaciente = consultaAtual.Paciente.Id;
            int numeroProntuario = consultaAtual.NumeroProntuario;

            if (receitaConsulta == null)
            {                
                new FormGerarReceita(codigoMedico, codigoPaciente, numeroProntuario, this).ShowDialog();
            }
            else
            {
                int receitaID = receitaConsulta.Numero;
                new FormGerarReceita(codigoMedico, codigoPaciente, numeroProntuario, this, receitaID).ShowDialog();
            }

        }

        public bool getReceitaConsulta(int receitaID)
        {
            bool retorno = false;

            if (receitaConsulta == null)
            {
                //btFormGerarReceita.Text = "Alterar Receita";
                this.receitaConsulta = new Receita();
                receitaConsulta.Numero = receitaID;
                consultaAtual.Receita = receitaConsulta;
                retorno = true;
            }

            return retorno;

        }

        private void btFinalizarConsulta_Click(object sender, EventArgs e)
        {
            Diagnostico d = new Diagnostico();
            d.Informacoes = txtBoxDiagnostico.Text;
            d.Data = DateTime.Now;

            consultaAtual.Diagnostico = d;

            //registra o diagnostico
            try
            {
                ServiceConsulta svc = new ServiceConsulta();
                consultaAtual.Diagnostico.Id =  svc.registrarDiagnostico(consultaAtual);

                MessageBox.Show("Diagnóstico registrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);           
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //finaliza a consulta
            try
            {
                ServiceConsulta svc2 = new ServiceConsulta();

                svc2.finalizarConsulta(consultaAtual);
                MessageBox.Show("Consulta Finalizada", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.formPai.Dispose();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
