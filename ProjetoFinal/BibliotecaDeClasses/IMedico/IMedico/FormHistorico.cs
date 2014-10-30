using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostConsulta;
using IMedico.localhostReceita;

namespace IMedico
{
    public partial class FormHistorico : Form
    {
        IMedico.localhostConsulta.Consulta[] historicoConsultas;
        IMedico.localhostReceita.ReceitaMedicamento[] medicamentosReceita;
        IMedico.localhostConsulta.Consulta consultaAtual;
        //IMedico.localhostReceita.Consulta consultaReceita;

        public FormHistorico(IMedico.localhostConsulta.Consulta c)
        {
            InitializeComponent();
            this.consultaAtual = c;

            //evento lock column width
            lvHistoricoConsulta.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvHistoricoConsulta_ColumnWidthChanging);
            lvMedicamentosReceita.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvMedicamentosReceita_ColumnWidthChanging);
        }

        //evento cancela a redimensão das colunas
        private void lvHistoricoConsulta_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvHistoricoConsulta.Columns[e.ColumnIndex].Width;
        }

        private void lvMedicamentosReceita_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvMedicamentosReceita.Columns[e.ColumnIndex].Width;
        }

        private void btHistoricoConsulta_Click(object sender, EventArgs e)
        {
            lvHistoricoConsulta.Items.Clear();
            try
            {
                ServiceConsulta svc = new ServiceConsulta();
                historicoConsultas = svc.listarHistoricoConsultas(consultaAtual);

                foreach (var item in historicoConsultas)
                {
                    ListViewItem itemHistorico = new ListViewItem();

                    itemHistorico.Text = item.DataConsulta.ToShortDateString();//0
                    itemHistorico.SubItems.Add(item.NumeroProntuario.ToString());//1
                    itemHistorico.SubItems.Add(item.Paciente.Id.ToString());//2
                    itemHistorico.SubItems.Add(item.Paciente.Nome);//3
                    itemHistorico.SubItems.Add(item.Medico.Nome);//4
                    itemHistorico.SubItems.Add(item.Observacoes);//5

                    if (item.Diagnostico == null)
                    {
                        itemHistorico.SubItems.Add("N/A");
                    }
                    else
                    {
                        itemHistorico.SubItems.Add(item.Diagnostico.Informacoes);//06
                    }

                    if (item.Receita == null)
                    {
                        itemHistorico.SubItems.Add("N/A");
                    }
                    else
                    {
                        itemHistorico.SubItems.Add(item.Receita.Numero.ToString());//07
                    }


                    lvHistoricoConsulta.Items.Add(itemHistorico);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }



        private void lvHistoricoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMedicamentosReceita.Items.Clear();
            
            if (lvHistoricoConsulta.SelectedItems.Count != 0)
            {
                if (lvHistoricoConsulta.SelectedItems[0].SubItems[7].Text == "N/A")
                {
                    MessageBox.Show("Esta consulta não gerou uma receita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    ServicoReceita svc = new ServicoReceita();
                    //IMedico.localhostReceita.Consulta consultaSelecionada = new IMedico.localhostReceita.Consulta();
                    IMedico.localhostReceita.Paciente pacienteReceita = new localhostReceita.Paciente();
                    pacienteReceita.Id = Convert.ToInt32(lvHistoricoConsulta.SelectedItems[0].SubItems[2].Text);

                    IMedico.localhostReceita.Receita receitaCompleta = new localhostReceita.Receita();
                    receitaCompleta.Numero = Convert.ToInt32(lvHistoricoConsulta.SelectedItems[0].SubItems[7].Text);
                    receitaCompleta.Paciente = pacienteReceita;

                    localhostReceita.ReceitaMedicamento filtro = new localhostReceita.ReceitaMedicamento();
                    filtro.Receita = receitaCompleta;


                    try
                    {
                        medicamentosReceita = svc.listarMedicamentosReceita(filtro);

                        foreach (var item in medicamentosReceita)
                        {
                            ListViewItem medicamento = new ListViewItem();
                            medicamento.Text = item.Receita.Numero.ToString();//0
                            medicamento.SubItems.Add(item.Receita.Paciente.Id.ToString()); //1
                            medicamento.SubItems.Add(item.Medicamento.Codigo.ToString()); //2
                            medicamento.SubItems.Add(item.Medicamento.NomeComercial); //3
                            medicamento.SubItems.Add(item.Medicamento.Composicao); //4
                            medicamento.SubItems.Add(item.Medicamento.ContraIndicacoes); //5
                            medicamento.SubItems.Add(item.Medicamento.Dosagem); //6
                            medicamento.SubItems.Add(item.Medicamento.Indicacoes); //7
                            medicamento.SubItems.Add(item.Medicamento.Fabricante); //8
                            medicamento.SubItems.Add(item.Instrucoes); //9
                            medicamento.SubItems.Add(item.Quantidade); //10
                            medicamento.SubItems.Add(item.Dosagem); //11
                            medicamento.SubItems.Add(item.TempoTratamento); //12
                            //medicamento.SubItems.Add(item.); //13

                            lvMedicamentosReceita.Items.Add(medicamento);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroopoppsp" + ex.Message);
                    }   
                }
            }
        }

        
    }
}
