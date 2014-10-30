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
    public partial class FormConsultarPacienteMedico : Form
    {
        Medico medicoConsulta;

        Consulta[] ConsultaTriagem;

        FormMainMedico formPrincipal;

        public FormConsultarPacienteMedico(Consulta c, Medico m, FormMainMedico formPrincipal)
        {
            InitializeComponent();
            //NovaConsulta = c;
            this.formPrincipal = formPrincipal;
            medicoConsulta = m;

            //lock column width
            lvPacienteTriagem.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvPacienteTriagem_ColumnWidthChanging);


        }

        //metodo lock column width
        private void lvPacienteTriagem_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvPacienteTriagem.Columns[e.ColumnIndex].Width;
        }

        private void btBuscarPaciente_Click(object sender, EventArgs e)
        {
            lvPacienteTriagem.Items.Clear();

            try
            {
                ServiceConsulta svc = new ServiceConsulta();

                Consulta c = new Consulta();

                c.DataConsulta = dpFiltroDataConsulta.Value;
                if (!string.IsNullOrWhiteSpace(txtBoxFiltroNome.Text))
                {
                    c.Paciente.Nome = txtBoxFiltroNome.Text;
                }

                ConsultaTriagem = svc.pacienteTriagem(c);

                if (ConsultaTriagem.Length <= 0)
                {
                    throw new Exception("Não há pacientes na triagem com estes parâmetros");
                }

                else
                {
                    foreach (var item in ConsultaTriagem)
                    {
                        ListViewItem pacienteTriagem = new ListViewItem();
                        pacienteTriagem.Text = item.DataConsulta.ToShortDateString();//0
                        pacienteTriagem.SubItems.Add(item.NumeroProntuario.ToString()); //1
                        pacienteTriagem.SubItems.Add(item.Enfermeiro.Id.ToString()); //2
                        pacienteTriagem.SubItems.Add(item.Enfermeiro.Nome); //3
                        pacienteTriagem.SubItems.Add(item.Paciente.Id.ToString()); //4
                        pacienteTriagem.SubItems.Add(item.Paciente.Nome); //5
                        pacienteTriagem.SubItems.Add(item.Paciente.DataNascimento.ToShortDateString()); //6
                        pacienteTriagem.SubItems.Add(item.Paciente.NomeMae); //7
                        pacienteTriagem.SubItems.Add(item.Paciente.NomePai); //8
                        pacienteTriagem.SubItems.Add(item.DadosVitais.Id.ToString()); //9
                        pacienteTriagem.SubItems.Add(item.DadosVitais.Pressao); //10
                        pacienteTriagem.SubItems.Add(item.DadosVitais.Pulso); //11
                        pacienteTriagem.SubItems.Add(item.DadosVitais.Temperatura); //12
                        pacienteTriagem.SubItems.Add(item.DadosVitais.Respiracao); //13
                        pacienteTriagem.SubItems.Add(item.Observacoes); //14
                        pacienteTriagem.SubItems.Add(item.Paciente.Sexo); //15

                        lvPacienteTriagem.Items.Add(pacienteTriagem);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvPacienteTriagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPacienteTriagem.SelectedItems.Count != 0)
            {
                lblNomePaciente.Text = "Nome do Paciente: " + lvPacienteTriagem.SelectedItems[0].SubItems[5].Text;
                lblDataNascimento.Text = "Data de Nascimento: " + lvPacienteTriagem.SelectedItems[0].SubItems[6].Text;
                lblNomeMae.Text = "Nome da Mãe: " + lvPacienteTriagem.SelectedItems[0].SubItems[7].Text;
                lblNomePai.Text = "Nome do Pai: " + lvPacienteTriagem.SelectedItems[0].SubItems[8].Text;
                lblSexo.Text = "Sexo: " + lvPacienteTriagem.SelectedItems[0].SubItems[15].Text;

                lblTemperatura.Text = "Temperatura: " + lvPacienteTriagem.SelectedItems[0].SubItems[12].Text;
                lblPulso.Text = "Pulso: " + lvPacienteTriagem.SelectedItems[0].SubItems[11].Text;
                lblRespiracao.Text = "Respiração: " + lvPacienteTriagem.SelectedItems[0].SubItems[13].Text;
                lblPressão.Text = "Pressao: " + lvPacienteTriagem.SelectedItems[0].SubItems[10].Text;
                lblObservações.Text = "Observações: " + lvPacienteTriagem.SelectedItems[0].SubItems[14].Text;

                lblEnfermeiro.Text = "Enfermeiro: " + lvPacienteTriagem.SelectedItems[0].SubItems[3].Text;
            }

        }

        private void btConfirmarPaciente_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.Id = Convert.ToInt32(lvPacienteTriagem.SelectedItems[0].SubItems[4].Text);

            if (p.Id == 0 || lvPacienteTriagem.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selecione um paciente da lista!");
            }
            else
            {

                Consulta NovaConsulta = new Consulta();
                
                DadosVitais dv = new DadosVitais();
                Enfermeiro en = new Enfermeiro();

                //carregando os dados coletados e atribiundo aos objetos da consulta atual

                //paciente
                
                p.Nome = lvPacienteTriagem.SelectedItems[0].SubItems[5].Text;
                p.DataNascimento = Convert.ToDateTime(lvPacienteTriagem.SelectedItems[0].SubItems[6].Text);
                p.NomeMae = lvPacienteTriagem.SelectedItems[0].SubItems[7].Text;
                p.NomePai = lvPacienteTriagem.SelectedItems[0].SubItems[8].Text;
                p.Sexo = lvPacienteTriagem.SelectedItems[0].SubItems[15].Text;
                NovaConsulta.Paciente = p;

                //medico
                NovaConsulta.Medico = medicoConsulta;

                //dados vitais
                dv.Id = Convert.ToInt32(lvPacienteTriagem.SelectedItems[0].SubItems[9].Text);
                dv.Respiracao = lvPacienteTriagem.SelectedItems[0].SubItems[13].Text;
                dv.Pressao = lvPacienteTriagem.SelectedItems[0].SubItems[10].Text;
                dv.Pulso = lvPacienteTriagem.SelectedItems[0].SubItems[11].Text;
                dv.Temperatura = lvPacienteTriagem.SelectedItems[0].SubItems[12].Text;
                NovaConsulta.DadosVitais = dv;

                //enfermeiro
                en.Nome = lvPacienteTriagem.SelectedItems[0].SubItems[3].Text;
                NovaConsulta.Enfermeiro = en;

                //consulta
                NovaConsulta.NumeroProntuario = Convert.ToInt32(lvPacienteTriagem.SelectedItems[0].SubItems[1].Text);
                NovaConsulta.Observacoes = lvPacienteTriagem.SelectedItems[0].SubItems[14].Text;

                this.formPrincipal.loadConsulta(NovaConsulta);
                this.formPrincipal.btnAlterarNome();

                ServiceConsulta svc = new ServiceConsulta();

                svc.setMedicoConsulta(NovaConsulta);

                MessageBox.Show("Paciente selecionado na consulta atual");
                this.Dispose();
                    
            }

        }




    }
}
