using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMedico.localhostConsulta;

namespace IMedico.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            loadMedicos();
        }


        private void loadMedicos()
        {
            ServiceConsulta svc = new ServiceConsulta();


            cbbMedicos.DataSource = svc.listarMedicosList();

            cbbMedicos.DisplayMember = "nome";
            cbbMedicos.ValueMember = "id";
            
            cbbMedicos.SelectedIndex = 0;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                Medico medicoLogin = new Medico();


                medicoLogin.Id = Convert.ToInt32(cbbMedicos.SelectedValue.ToString());


                if (string.IsNullOrWhiteSpace(txtBoxLogin.Text))
                {
                    txtBoxLogin.Text = "";
                    throw new Exception("Preencha o campo LOGIN");
                }
                else
                {
                    medicoLogin.Login = txtBoxLogin.Text;
                }

                if (string.IsNullOrWhiteSpace(txtBoxSenha.Text))
                {
                    txtBoxSenha.Text = "";
                    throw new Exception("Preencha o campo SENHA");
                }
                else
                {
                    medicoLogin.Senha = txtBoxSenha.Text;
                }


                ServiceConsulta svc = new ServiceConsulta();

                Medico medicoConsulta = svc.loginMedico(medicoLogin);

                new FormMainMedico(medicoConsulta).ShowDialog();

                this.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
