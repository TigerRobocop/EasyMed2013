using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostConsulta;


//feito em sala
namespace IMedico
{
    public partial class FormMainMedico : Form
    {
        Consulta NovaConsulta;
        Medico medico;
        Paciente paciente;

        public FormMainMedico()
        {
            InitializeComponent();

            carregarAtores();
        }

        private void btConsultaPaciente_Click(object sender, EventArgs e)
        {
            new FormConsultarPacienteMedico().ShowDialog();

         
        }

        private void btFormGerarParecer_Click(object sender, EventArgs e)
        {
            new FormGerarParecer(this.paciente, this.medico, this.NovaConsulta).ShowDialog();
        }


        private void carregarAtores()
        {
            NovaConsulta = new Consulta();
            this.NovaConsulta.NumeroProntuario = 1;

            medico = new Medico();
            this.medico.Nome = "Gisomation";
            NovaConsulta.Medico = medico;

            paciente = new Paciente();
            this.paciente.Nome = "Cri Cri";
            NovaConsulta.Paciente = paciente;
        }
       

        //já que na tela do médico só precisará exibir os dados do paciente sendo atendido no momento, 
        //a gente pode usar um listbox ao invés de uma tabela (listview ou datagridview por exemplo)
        //a tela já carregaria com todos os dados necessários
        //a mesma coisa pra triagem. na hora de programar a gente ve qual seria o melhor

    }
}
