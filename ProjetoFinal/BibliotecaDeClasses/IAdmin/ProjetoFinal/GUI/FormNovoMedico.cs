using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecaDeClasses;
using ServiceAdmin.EasyMed.Service;
using IAdmin.GUI;

namespace ProjetoFinal
{
    public partial class FormNovoMedico : Form
    {
        //Contrutor para consultar
        FormGerenciarMedicos formInicial;
        public FormNovoMedico(FormGerenciarMedicos formInicial)
        {
            InitializeComponent();
            ListaUF();
            this.formInicial = formInicial;
        }
        

        private void ListaUF()
        {
            string[] UF = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            foreach (var item in UF)
            {
                cbbUF.Items.Add(item);
            }

        }

        

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            Medico m = new Medico();
            WebServiceMedico serviceAdmin = new WebServiceMedico();
            m.Nome = txtBoxNome.Text;
            m.Rg = mtxtBoxRG.Text;
            m.Senha = txtBoxSenha.Text;
            m.Telefone = mtxtBoxTelefone.Text;
            m.Login = txtBoxLogin.Text;
            m.Crm = txtBoxCrm.Text;
            m.Especializacao = txtBoxEspecializacao.Text;
            m.DataNascimento = dpDataNascimento.Value;

            Endereco en = new Endereco();
            en.Bairro = txtBoxBairro.Text;
            en.Cidade = txtBoxCidade.Text;
            en.Complemento = txtBoxComplemento.Text;
            en.Logradouro = txtBoxEndereco.Text;
            en.Numero = Convert.ToInt32(txtBoxNumero.Text);
            en.Pais = txtBoxPais.Text;
            en.Uf = cbbUF.Text;
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
               
                    serviceAdmin.CadastrarMedico(m, en);
                    this.formInicial.atualizarDataGrid();
                    this.Dispose();
                    MessageBox.Show("Médico Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
