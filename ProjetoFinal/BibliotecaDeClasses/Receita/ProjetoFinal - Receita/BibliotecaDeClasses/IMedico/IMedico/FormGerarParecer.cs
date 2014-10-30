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
        Paciente pacienteConsulta;
        Medico medicoConsulta;
        Consulta consultaAtual;
        IMedico.localhostReceita.Receita receitaConsulta;
        

        public FormGerarParecer(Paciente p, Medico m, Consulta c)
        {
            InitializeComponent();
            this.pacienteConsulta = p;
            this.medicoConsulta = m;
            this.consultaAtual = c;


            lblNomePaciente.Text += " " + pacienteConsulta.Nome;
            lblNomeMedico.Text += " " + medicoConsulta.Nome;

        }

        private void btFormGerarAtestado_Click(object sender, EventArgs e)
        {
            new FormGerarAtestado().ShowDialog();
        }

        private void btFormGerarReceita_Click(object sender, EventArgs e)
        {
            new FormGerarReceita(medicoConsulta.Id, pacienteConsulta.Id).ShowDialog();
            receitaConsulta = new IMedico.localhostReceita.Receita();
            receitaConsulta.Numero = 1;

            lblReceitaGerada.Text = "Receita Gerada";
            
        }

        private void btFinalizarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
             //ServiceConsulta.EasyMed.Service.ServiceConsulta svc = new ServiceConsulta.EasyMed.Service.ServiceConsulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
    }
}
