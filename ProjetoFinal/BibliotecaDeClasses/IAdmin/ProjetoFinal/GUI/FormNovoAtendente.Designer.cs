namespace ProjetoFinal
{
    partial class FormNovoAtendente
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
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtxtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.dpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbEndereco.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEndereco
            // 
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
            this.gbEndereco.Location = new System.Drawing.Point(25, 126);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(534, 240);
            this.gbEndereco.TabIndex = 2;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "A";
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
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtBoxNome);
            this.gbDadosPessoais.Controls.Add(this.mtxtBoxTelefone);
            this.gbDadosPessoais.Controls.Add(this.dpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.mtxtBoxRG);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(25, 9);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(533, 99);
            this.gbDadosPessoais.TabIndex = 3;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "A";
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
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(18, 57);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG:";
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(368, 57);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // mtxtBoxRG
            // 
            this.mtxtBoxRG.Location = new System.Drawing.Point(57, 54);
            this.mtxtBoxRG.Mask = "0-000-000";
            this.mtxtBoxRG.Name = "mtxtBoxRG";
            this.mtxtBoxRG.Size = new System.Drawing.Size(67, 20);
            this.mtxtBoxRG.TabIndex = 4;
            // 
            // dpDataNascimento
            // 
            this.dpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataNascimento.Location = new System.Drawing.Point(246, 54);
            this.dpDataNascimento.Name = "dpDataNascimento";
            this.dpDataNascimento.Size = new System.Drawing.Size(111, 20);
            this.dpDataNascimento.TabIndex = 5;
            // 
            // mtxtBoxTelefone
            // 
            this.mtxtBoxTelefone.Location = new System.Drawing.Point(430, 54);
            this.mtxtBoxTelefone.Mask = "(00)0000-0000";
            this.mtxtBoxTelefone.Name = "mtxtBoxTelefone";
            this.mtxtBoxTelefone.Size = new System.Drawing.Size(82, 20);
            this.mtxtBoxTelefone.TabIndex = 6;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(62, 23);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(450, 20);
            this.txtBoxNome.TabIndex = 7;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(211, 372);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(153, 29);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "A";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormNovoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 417);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.gbEndereco);
            this.Name = "FormNovoAtendente";
            this.Text = "Novo Atendente";
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEndereco;
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
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.MaskedTextBox mtxtBoxTelefone;
        private System.Windows.Forms.DateTimePicker dpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtBoxRG;
        private System.Windows.Forms.Button btSalvar;
    }
}