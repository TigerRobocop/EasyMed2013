namespace SocketEasyMedReceita
{
    partial class FormValidaReceita
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
            this.btFinalizarReceita = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSelecionarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResultadoPaciente = new System.Windows.Forms.Label();
            this.lbResultadoMedico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFinalizarReceita
            // 
            this.btFinalizarReceita.Location = new System.Drawing.Point(508, 205);
            this.btFinalizarReceita.Name = "btFinalizarReceita";
            this.btFinalizarReceita.Size = new System.Drawing.Size(101, 28);
            this.btFinalizarReceita.TabIndex = 1;
            this.btFinalizarReceita.Text = "Finalizar Receita";
            this.btFinalizarReceita.UseVisualStyleBackColor = true;
            this.btFinalizarReceita.Click += new System.EventHandler(this.btFinalizarReceita_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aguardando Solicitação do Paciente",
            "Em Produção",
            "Receita Finalizada(Recolhido)"});
            this.comboBox1.Location = new System.Drawing.Point(8, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 17);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResultadoMedico);
            this.groupBox1.Controls.Add(this.lbResultadoPaciente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSelecionarPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitoramento das Receitas";
            // 
            // btSelecionarPaciente
            // 
            this.btSelecionarPaciente.Location = new System.Drawing.Point(13, 144);
            this.btSelecionarPaciente.Name = "btSelecionarPaciente";
            this.btSelecionarPaciente.Size = new System.Drawing.Size(277, 23);
            this.btSelecionarPaciente.TabIndex = 4;
            this.btSelecionarPaciente.Text = "Selecionar Paciente";
            this.btSelecionarPaciente.UseVisualStyleBackColor = true;
            this.btSelecionarPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número da Receita";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(351, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Paciente e do Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistuação da Receita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do Médico:";
            // 
            // lbResultadoPaciente
            // 
            this.lbResultadoPaciente.AutoSize = true;
            this.lbResultadoPaciente.Location = new System.Drawing.Point(128, 68);
            this.lbResultadoPaciente.Name = "lbResultadoPaciente";
            this.lbResultadoPaciente.Size = new System.Drawing.Size(0, 13);
            this.lbResultadoPaciente.TabIndex = 8;
            // 
            // lbResultadoMedico
            // 
            this.lbResultadoMedico.AutoSize = true;
            this.lbResultadoMedico.Location = new System.Drawing.Point(126, 101);
            this.lbResultadoMedico.Name = "lbResultadoMedico";
            this.lbResultadoMedico.Size = new System.Drawing.Size(0, 13);
            this.lbResultadoMedico.TabIndex = 9;
            // 
            // FormValidaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFinalizarReceita);
            this.Name = "FormValidaReceita";
            this.Text = "Validar Receita";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFinalizarReceita;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelecionarPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultadoMedico;
        private System.Windows.Forms.Label lbResultadoPaciente;
    }
}

