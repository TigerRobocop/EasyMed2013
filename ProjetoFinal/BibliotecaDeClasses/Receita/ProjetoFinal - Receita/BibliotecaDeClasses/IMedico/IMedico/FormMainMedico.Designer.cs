namespace IMedico
{
    partial class FormMainMedico
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
            this.btFormConsultaPaciente = new System.Windows.Forms.Button();
            this.btFormGerarParecer = new System.Windows.Forms.Button();
            this.gbDadosPaciente = new System.Windows.Forms.GroupBox();
            this.gbTriagem = new System.Windows.Forms.GroupBox();
            this.lblRespiracao = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblPressão = new System.Windows.Forms.Label();
            this.lblEnfermeiro = new System.Windows.Forms.Label();
            this.lblPulso = new System.Windows.Forms.Label();
            this.lblObservações = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.btnFormPesquisarHistorico = new System.Windows.Forms.Button();
            this.gbDadosPaciente.SuspendLayout();
            this.gbTriagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFormConsultaPaciente
            // 
            this.btFormConsultaPaciente.Location = new System.Drawing.Point(38, 33);
            this.btFormConsultaPaciente.Name = "btFormConsultaPaciente";
            this.btFormConsultaPaciente.Size = new System.Drawing.Size(398, 39);
            this.btFormConsultaPaciente.TabIndex = 0;
            this.btFormConsultaPaciente.Text = "Consulta - Paciente";
            this.btFormConsultaPaciente.UseVisualStyleBackColor = true;
            this.btFormConsultaPaciente.Click += new System.EventHandler(this.btConsultaPaciente_Click);
            // 
            // btFormGerarParecer
            // 
            this.btFormGerarParecer.Location = new System.Drawing.Point(38, 472);
            this.btFormGerarParecer.Name = "btFormGerarParecer";
            this.btFormGerarParecer.Size = new System.Drawing.Size(398, 36);
            this.btFormGerarParecer.TabIndex = 7;
            this.btFormGerarParecer.Text = "Gerar Parecer";
            this.btFormGerarParecer.UseVisualStyleBackColor = true;
            this.btFormGerarParecer.Click += new System.EventHandler(this.btFormGerarParecer_Click);
            // 
            // gbDadosPaciente
            // 
            this.gbDadosPaciente.Controls.Add(this.gbTriagem);
            this.gbDadosPaciente.Controls.Add(this.lblSexo);
            this.gbDadosPaciente.Controls.Add(this.lblNomePai);
            this.gbDadosPaciente.Controls.Add(this.lblNomeMae);
            this.gbDadosPaciente.Controls.Add(this.lblDataNascimento);
            this.gbDadosPaciente.Controls.Add(this.lblNomePaciente);
            this.gbDadosPaciente.Location = new System.Drawing.Point(38, 93);
            this.gbDadosPaciente.Name = "gbDadosPaciente";
            this.gbDadosPaciente.Size = new System.Drawing.Size(398, 308);
            this.gbDadosPaciente.TabIndex = 8;
            this.gbDadosPaciente.TabStop = false;
            this.gbDadosPaciente.Text = "Dados do Paciente - Número: ";
            // 
            // gbTriagem
            // 
            this.gbTriagem.Controls.Add(this.lblRespiracao);
            this.gbTriagem.Controls.Add(this.lblTemperatura);
            this.gbTriagem.Controls.Add(this.lblPressão);
            this.gbTriagem.Controls.Add(this.lblEnfermeiro);
            this.gbTriagem.Controls.Add(this.lblPulso);
            this.gbTriagem.Controls.Add(this.lblObservações);
            this.gbTriagem.Location = new System.Drawing.Point(19, 116);
            this.gbTriagem.Name = "gbTriagem";
            this.gbTriagem.Size = new System.Drawing.Size(361, 176);
            this.gbTriagem.TabIndex = 12;
            this.gbTriagem.TabStop = false;
            this.gbTriagem.Text = "Triagem";
            // 
            // lblRespiracao
            // 
            this.lblRespiracao.AutoSize = true;
            this.lblRespiracao.Location = new System.Drawing.Point(11, 54);
            this.lblRespiracao.Name = "lblRespiracao";
            this.lblRespiracao.Size = new System.Drawing.Size(64, 13);
            this.lblRespiracao.TabIndex = 13;
            this.lblRespiracao.Text = "Respiração:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(11, 16);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 12;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblPressão
            // 
            this.lblPressão.AutoSize = true;
            this.lblPressão.Location = new System.Drawing.Point(11, 73);
            this.lblPressão.Name = "lblPressão";
            this.lblPressão.Size = new System.Drawing.Size(51, 13);
            this.lblPressão.TabIndex = 11;
            this.lblPressão.Text = "Pressão: ";
            // 
            // lblEnfermeiro
            // 
            this.lblEnfermeiro.AutoSize = true;
            this.lblEnfermeiro.Location = new System.Drawing.Point(14, 151);
            this.lblEnfermeiro.Name = "lblEnfermeiro";
            this.lblEnfermeiro.Size = new System.Drawing.Size(63, 13);
            this.lblEnfermeiro.TabIndex = 8;
            this.lblEnfermeiro.Text = "Enfermeiro: ";
            // 
            // lblPulso
            // 
            this.lblPulso.AutoSize = true;
            this.lblPulso.Location = new System.Drawing.Point(11, 35);
            this.lblPulso.Name = "lblPulso";
            this.lblPulso.Size = new System.Drawing.Size(39, 13);
            this.lblPulso.TabIndex = 10;
            this.lblPulso.Text = "Pulso: ";
            // 
            // lblObservações
            // 
            this.lblObservações.AutoSize = true;
            this.lblObservações.Location = new System.Drawing.Point(11, 92);
            this.lblObservações.Name = "lblObservações";
            this.lblObservações.Size = new System.Drawing.Size(76, 13);
            this.lblObservações.TabIndex = 9;
            this.lblObservações.Text = "Observações: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(222, 45);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo: ";
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Location = new System.Drawing.Point(15, 87);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(74, 13);
            this.lblNomePai.TabIndex = 7;
            this.lblNomePai.Text = "Nome do Pai: ";
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Location = new System.Drawing.Point(15, 66);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(80, 13);
            this.lblNomeMae.TabIndex = 6;
            this.lblNomeMae.Text = "Nome da Mãe: ";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(15, 45);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(110, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de Nascimento: ";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(15, 24);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(98, 13);
            this.lblNomePaciente.TabIndex = 4;
            this.lblNomePaciente.Text = "Nome do Paciente:";
            // 
            // btnFormPesquisarHistorico
            // 
            this.btnFormPesquisarHistorico.Location = new System.Drawing.Point(38, 417);
            this.btnFormPesquisarHistorico.Name = "btnFormPesquisarHistorico";
            this.btnFormPesquisarHistorico.Size = new System.Drawing.Size(398, 38);
            this.btnFormPesquisarHistorico.TabIndex = 9;
            this.btnFormPesquisarHistorico.Text = "Pesquisar Histórico do Paciente";
            this.btnFormPesquisarHistorico.UseVisualStyleBackColor = true;
            // 
            // FormMainMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 520);
            this.Controls.Add(this.btnFormPesquisarHistorico);
            this.Controls.Add(this.gbDadosPaciente);
            this.Controls.Add(this.btFormGerarParecer);
            this.Controls.Add(this.btFormConsultaPaciente);
            this.Name = "FormMainMedico";
            this.Text = "Main - Médico";
            this.gbDadosPaciente.ResumeLayout(false);
            this.gbDadosPaciente.PerformLayout();
            this.gbTriagem.ResumeLayout(false);
            this.gbTriagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormConsultaPaciente;
        public System.Windows.Forms.Button btFormGerarParecer;
        private System.Windows.Forms.GroupBox gbDadosPaciente;
        private System.Windows.Forms.GroupBox gbTriagem;
        private System.Windows.Forms.Label lblRespiracao;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblPressão;
        private System.Windows.Forms.Label lblEnfermeiro;
        private System.Windows.Forms.Label lblPulso;
        private System.Windows.Forms.Label lblObservações;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Button btnFormPesquisarHistorico;
    }
}