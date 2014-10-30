using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoFinal;
using ServiceAdmin.EasyMed.Service;
using BibliotecaDeClasses;
using ProjetoFinal.GUI;

namespace IAdmin.GUI
{
    public partial class FormGerenciarMedicos : Form
    {

        public FormGerenciarMedicos()
        {
            InitializeComponent();
        }

        public void atualizarDataGrid()
        {
            WebServiceMedico serviceMedico = new WebServiceMedico();

            List<Medico> lista = serviceMedico.listarMedico();
            if (lista.Count > 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "CRM";
                dataGridView1.Columns[2].Name = "NOME";
                dataGridView1.Columns[3].Name = "RG";
                dataGridView1.Columns[4].Name = "Telefone";
                dataGridView1.Columns[5].Name = "Especialização";
                dataGridView1.Columns[6].Name = "Data de Nascimento";
                dataGridView1.Rows.Clear();

                foreach (var item in lista)
                {


                    //Inserindo os registros no datagrid
                    string[] row = new string[] { item.Id.ToString(), item.Crm, item.Nome, item.Rg, item.Telefone, item.Especializacao, item.DataNascimento.ToString() };
                    dataGridView1.Rows.Add(row);

                }


            }
            else
            {
                MessageBox.Show("Atenção Nenhum Médico Cadasatrado!", "Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Rows.Clear();
            }

        }

        private void btCadastrarNovo_Click(object sender, EventArgs e)
        {
            FormNovoMedico novo = new FormNovoMedico(this);
            novo.ShowDialog();
        }

        public void btListarTodos_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void btEditarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string idMedico = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FormEditarMedico editar = new FormEditarMedico(this, idMedico);
                editar.Show();
            }
            catch (NullReferenceException nulo)
            {
                MessageBox.Show("Atenção nenhum médico Selecionado", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExcluirCadastro_Click(object sender, EventArgs e)
        {
            WebServiceMedico serviceMedico = new WebServiceMedico();
            try
            {
                string idMedico = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Medico medico = new Medico();
                medico.Id = Int32.Parse(idMedico);
                serviceMedico.excluirMedico(medico);
                atualizarDataGrid();
                MessageBox.Show("O Médico foi Excluido com Sucesso", "Ação Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (NullReferenceException nulo)
            {
                MessageBox.Show("Atenção nenhum médico Selecionado", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btBuscaFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                string crm = txtBoxFiltroCRM.Text;
                string rg = txtBoxFiltroRG.Text;
                string nome = txtBoxFiltroNome.Text;
                WebServiceMedico serviceMedico = new WebServiceMedico();


                List<Medico> lista = serviceMedico.filtroMedico(crm, rg, nome);


                if (lista.Count > 0)
                {
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "CRM";
                    dataGridView1.Columns[2].Name = "NOME";
                    dataGridView1.Columns[3].Name = "RG";
                    dataGridView1.Columns[4].Name = "Telefone";
                    dataGridView1.Columns[5].Name = "Especialização";
                    dataGridView1.Columns[6].Name = "Data de Nascimento";
                    dataGridView1.Rows.Clear();



                    foreach (var item in lista)
                    {
                        //Inserindo os registros no datagrid
                        string[] row = new string[] { item.Id.ToString(), item.Crm, item.Nome, item.Rg, item.Telefone, item.Especializacao, item.DataNascimento.ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                }
                else
                {
                    MessageBox.Show("Atenção não encontramos resultados!", "Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        



        }
    
}
