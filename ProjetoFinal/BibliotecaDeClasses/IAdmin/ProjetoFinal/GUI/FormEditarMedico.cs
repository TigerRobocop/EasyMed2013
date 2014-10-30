using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IAdmin.GUI;
using ServiceAdmin.EasyMed.Service;
using BibliotecaDeClasses;

namespace ProjetoFinal.GUI
{
    public partial class FormEditarMedico : Form
    {
        FormGerenciarMedicos formInicial;
        int IdMedico = 0, IdEndereco = 0 ;
        public FormEditarMedico(FormGerenciarMedicos formInicial,string id)
        {
            InitializeComponent();
            ListaUF();
            this.formInicial = formInicial;
            IdMedico = Int32.Parse(id);
        }


        private void ListaUF()
        {
            string[] UF = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            foreach (var item in UF)
            {
                cbbUF.Items.Add(item);
            }

        }


        WebServiceMedico service = new WebServiceMedico();
        private void btAlterar_Click(object sender, EventArgs e)
        {
            
            Medico m = new Medico();
            Endereco en = new Endereco();

            m.Crm = txtBoxCrm.Text;
            m.DataNascimento = dpDataNascimento.Value;
            m.Especializacao = txtBoxEspecializacao.Text;
            m.Nome = txtBoxNome.Text;
            m.Rg = mtxtBoxRG.Text;
            m.Senha = txtBoxSenha.Text;
            m.Telefone = mtxtBoxTelefone.Text;
            m.Login = txtBoxLogin.Text;
            //Id Medico e Id Endereço
            en.Id = IdEndereco;
            m.Endereco = en;
            m.Id = IdMedico;
            //Endereco
            en.Logradouro = txtBoxEndereco.Text;
            en.Numero = Convert.ToInt32(txtBoxNumero.Text);
            en.Pais = txtBoxPais.Text;
            en.Uf = cbbUF.SelectedItem.ToString();
            en.Complemento = txtBoxComplemento.Text;
            en.Cidade = txtBoxCidade.Text;
            en.Bairro = txtBoxBairro.Text;
            
            try
            {
                if (!mtxtBoxRG.MaskCompleted)
                {
                    throw new Exception("Atenção complete o campo RG!");
                }
                else if (!mtxtBoxTelefone.MaskCompleted)
                {
                    throw new Exception("Atenção complete o campo TELEFONE!");
                }
                service.editarMedico(m, en);
                MessageBox.Show("Médico Alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.formInicial.atualizarDataGrid();
                this.Dispose();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormEditarMedico_Load(object sender, EventArgs e)
        {
            //Pegamos informações do Médico
           List<Medico> listaMedico = service.listaMedico(IdMedico);

           foreach (var item in listaMedico)
           {
               txtBoxNome.Text = item.Nome;
               txtBoxLogin.Text = item.Login;
               txtBoxEspecializacao.Text = item.Especializacao;
               txtBoxCrm.Text = item.Crm;
               txtBoxSenha.Text = item.Senha;
               mtxtBoxRG.Text = item.Rg;
               mtxtBoxTelefone.Text = item.Telefone;
               //O ID do Endereço do Médicod
               IdEndereco = item.Endereco.Id;

           }
            //Lista de Endereço
           List<Endereco> listaEndereco = service.listaEndereco(IdEndereco);

           foreach (var item in listaEndereco)
           {
               txtBoxBairro.Text = item.Bairro;
               txtBoxCidade.Text = item.Cidade;
               txtBoxComplemento.Text = item.Complemento;
               txtBoxEndereco.Text = item.Logradouro;
               txtBoxNumero.Text = item.Numero.ToString();
               txtBoxPais.Text = item.Pais;
               cbbUF.SelectedItem = item.Uf;
               
           }
        }

        private void txtBoxCrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
               char.IsSymbol(e.KeyChar) || //Símbolos
               char.IsWhiteSpace(e.KeyChar) || //Espaço
               char.IsPunctuation(e.KeyChar)) //Pontuação
               
                e.Handled = true; //Não permitir
        }

        private void txtBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
               char.IsSymbol(e.KeyChar) || //Símbolos
               char.IsWhiteSpace(e.KeyChar) || //Espaço
               char.IsPunctuation(e.KeyChar)) //Pontuação

                e.Handled = true; //Não permitir
        }
    }
}
