namespace IAdmin.GUI
{
    partial class FormNovoMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.mtxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtxtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.txtBoxComplemento = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtBoxPais = new System.Windows.Forms.TextBox();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblCrm = new System.Windows.Forms.Label();
            this.txtBoxEspecializacao = new System.Windows.Forms.TextBox();
            this.txtBoxCrm = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(211, 465);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(153, 29);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtBoxCrm);
            this.gbDadosPessoais.Controls.Add(this.txtBoxEspecializacao);
            this.gbDadosPessoais.Controls.Add(this.lblCrm);
            this.gbDadosPessoais.Controls.Add(this.lblEspecializacao);
            this.gbDadosPessoais.Controls.Add(this.txtBoxNome);
            this.gbDadosPessoais.Controls.Add(this.mtxtBoxTelefone);
            this.gbDadosPessoais.Controls.Add(this.dpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.mtxtBoxRG);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(25, 93);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(533, 120);
            this.gbDadosPessoais.TabIndex = 6;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(62, 23);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(450, 20);
            this.txtBoxNome.TabIndex = 7;
            // 
            // mtxtBoxTelefone
            // 
            this.mtxtBoxTelefone.Location = new System.Drawing.Point(430, 54);
            this.mtxtBoxTelefone.Mask = "(00)0000-0000";
            this.mtxtBoxTelefone.Name = "mtxtBoxTelefone";
            this.mtxtBoxTelefone.Size = new System.Drawing.Size(82, 20);
            this.mtxtBoxTelefone.TabIndex = 6;
            // 
            // dpDataNascimento
            // 
            this.dpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataNascimento.Location = new System.Drawing.Point(246, 54);
            this.dpDataNascimento.Name = "dpDataNascimento";
            this.dpDataNascimento.Size = new System.Drawing.Size(111, 20);
            this.dpDataNascimento.TabIndex = 5;
            // 
            // mtxtBoxRG
            // 
            this.mtxtBoxRG.Location = new System.Drawing.Point(57, 54);
            this.mtxtBoxRG.Mask = "0-000-000";
            this.mtxtBoxRG.Name = "mtxtBoxRG";
            this.mtxtBoxRG.Size = new System.Drawing.Size(67, 20);
            this.mtxtBoxRG.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(368, 57);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de Nascimento: ";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(18, 55);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtBoxPais);
            this.gbEndereco.Controls.Add(this.lblPais);
            this.gbEndereco.Controls.Add(this.cbbUF);
            this.gbEndereco.Controls.Add(this.txtBoxBairro);
            this.gbEndereco.Controls.Add(this.label2);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.label7);
            this.gbEndereco.Controls.Add(this.txtBoxCidade);
            this.gbEndereco.Controls.Add(this.txtBoxEndereco);
            this.gbEndereco.Controls.Add(this.txtBoxComplemento);
            this.gbEndereco.Controls.Add(this.txtBoxNumero);
            this.gbEndereco.Location = new System.Drawing.Point(25, 219);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(534, 240);
            this.gbEndereco.TabIndex = 5;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // cbbUF
            // 
            this.cbbUF.AllowDrop = true;
            this.cbbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Location = new System.Drawing.Point(63, 196);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(99, 21);
            this.cbbUF.TabIndex = 7;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Location = new System.Drawing.Point(82, 110);
            this.txtBoxBairro.MaxLength = 60;
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(419, 20);
            this.txtBoxBairro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logradouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "UF:";
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Location = new System.Drawing.Point(80, 153);
            this.txtBoxCidade.MaxLength = 60;
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(421, 20);
            this.txtBoxCidade.TabIndex = 6;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(89, 24);
            this.txtBoxEndereco.MaxLength = 80;
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(412, 20);
            this.txtBoxEndereco.TabIndex = 2;
            // 
            // txtBoxComplemento
            // 
            this.txtBoxComplemento.Location = new System.Drawing.Point(313, 67);
            this.txtBoxComplemento.MaxLength = 60;
            this.txtBoxComplemento.Name = "txtBoxComplemento";
            this.txtBoxComplemento.Size = new System.Drawing.Size(188, 20);
            this.txtBoxComplemento.TabIndex = 4;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(84, 67);
            this.txtBoxNumero.MaxLength = 20;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(132, 20);
            this.txtBoxNumero.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(192, 200);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(35, 13);
            this.lblPais.TabIndex = 8;
            this.lblPais.Text = "País: ";
            // 
            // txtBoxPais
            // 
            this.txtBoxPais.Location = new System.Drawing.Point(239, 197);
            this.txtBoxPais.Name = "txtBoxPais";
            this.txtBoxPais.Size = new System.Drawing.Size(262, 20);
            this.txtBoxPais.TabIndex = 9;
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(18, 84);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(84, 13);
            this.lblEspecializacao.TabIndex = 8;
            this.lblEspecializacao.Text = "Especialização: ";
            // 
            // lblCrm
            // 
            this.lblCrm.AutoSize = true;
            this.lblCrm.Location = new System.Drawing.Point(332, 84);
            this.lblCrm.Name = "lblCrm";
            this.lblCrm.Size = new System.Drawing.Size(37, 13);
            this.lblCrm.TabIndex = 9;
            this.lblCrm.Text = "CRM: ";
            // 
            // txtBoxEspecializacao
            // 
            this.txtBoxEspecializacao.Location = new System.Drawing.Point(108, 81);
            this.txtBoxEspecializacao.Name = "txtBoxEspecializacao";
            this.txtBoxEspecializacao.Size = new System.Drawing.Size(188, 20);
            this.txtBoxEspecializacao.TabIndex = 12;
            // 
            // txtBoxCrm
            // 
            this.txtBoxCrm.Location = new System.Drawing.Point(375, 81);
            this.txtBoxCrm.Name = "txtBoxCrm";
            this.txtBoxCrm.Size = new System.Drawing.Size(137, 20);
            this.txtBoxCrm.TabIndex = 13;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtBoxSenha);
            this.gbLogin.Controls.Add(this.txtBoxLogin);
            this.gbLogin.Controls.Add(this.lblSenha);
            this.gbLogin.Controls.Add(this.lblLogin);
            this.gbLogin.Location = new System.Drawing.Point(107, 9);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(379, 69);
            this.gbLogin.TabIndex = 8;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Criar Novo Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(23, 40);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(23, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login: ";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(68, 13);
            this.txtBoxLogin.MaxLength = 20;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(288, 20);
            this.txtBoxLogin.TabIndex = 9;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(68, 40);
            this.txtBoxSenha.MaxLength = 20;
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(288, 20);
            this.txtBoxSenha.TabIndex = 14;
            // 
            // FormNovoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 506);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.gbEndereco);
            this.Name = "FormNovoMedico";
            this.Text = "Cadastrar Novo";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.MaskedTextBox mtxtBoxTelefone;
        private System.Windows.Forms.DateTimePicker dpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtBoxRG;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxComplemento;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxCrm;
        private System.Windows.Forms.TextBox txtBoxEspecializacao;
        private System.Windows.Forms.Label lblCrm;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
    }
}