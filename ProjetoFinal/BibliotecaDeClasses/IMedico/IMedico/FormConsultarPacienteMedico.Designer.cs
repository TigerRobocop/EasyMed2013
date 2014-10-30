namespace IMedico
{
    partial class FormConsultarPacienteMedico
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
            this.gbBuscaFiltroPaciente = new System.Windows.Forms.GroupBox();
            this.btBuscarPaciente = new System.Windows.Forms.Button();
            this.dpFiltroDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtBoxFiltroNome = new System.Windows.Forms.TextBox();
            this.lblFiltroNome = new System.Windows.Forms.Label();
            this.lblFiltroDataConsulta = new System.Windows.Forms.Label();
            this.btConfirmarPaciente = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
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
            this.lvPacienteTriagem = new System.Windows.Forms.ListView();
            this.DataConsulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroProntuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnfermeiroID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnfermeiroNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteDN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteNomeMae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteNomePai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DadosVitaisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVpressao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVpulso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVtemperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVrespiracao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbBuscaFiltroPaciente.SuspendLayout();
            this.gbDadosPaciente.SuspendLayout();
            this.gbTriagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscaFiltroPaciente
            // 
            this.gbBuscaFiltroPaciente.Controls.Add(this.btBuscarPaciente);
            this.gbBuscaFiltroPaciente.Controls.Add(this.dpFiltroDataConsulta);
            this.gbBuscaFiltroPaciente.Controls.Add(this.txtBoxFiltroNome);
            this.gbBuscaFiltroPaciente.Controls.Add(this.lblFiltroNome);
            this.gbBuscaFiltroPaciente.Controls.Add(this.lblFiltroDataConsulta);
            this.gbBuscaFiltroPaciente.Location = new System.Drawing.Point(21, 21);
            this.gbBuscaFiltroPaciente.Name = "gbBuscaFiltroPaciente";
            this.gbBuscaFiltroPaciente.Size = new System.Drawing.Size(398, 96);
            this.gbBuscaFiltroPaciente.TabIndex = 0;
            this.gbBuscaFiltroPaciente.TabStop = false;
            this.gbBuscaFiltroPaciente.Text = "Busca Paciente: preencha os filtros desejados";
            // 
            // btBuscarPaciente
            // 
            this.btBuscarPaciente.Location = new System.Drawing.Point(305, 48);
            this.btBuscarPaciente.Name = "btBuscarPaciente";
            this.btBuscarPaciente.Size = new System.Drawing.Size(75, 37);
            this.btBuscarPaciente.TabIndex = 4;
            this.btBuscarPaciente.Text = "Buscar";
            this.btBuscarPaciente.UseVisualStyleBackColor = true;
            this.btBuscarPaciente.Click += new System.EventHandler(this.btBuscarPaciente_Click);
            // 
            // dpFiltroDataConsulta
            // 
            this.dpFiltroDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFiltroDataConsulta.Location = new System.Drawing.Point(102, 27);
            this.dpFiltroDataConsulta.Name = "dpFiltroDataConsulta";
            this.dpFiltroDataConsulta.Size = new System.Drawing.Size(97, 20);
            this.dpFiltroDataConsulta.TabIndex = 3;
            // 
            // txtBoxFiltroNome
            // 
            this.txtBoxFiltroNome.Location = new System.Drawing.Point(63, 57);
            this.txtBoxFiltroNome.Name = "txtBoxFiltroNome";
            this.txtBoxFiltroNome.Size = new System.Drawing.Size(227, 20);
            this.txtBoxFiltroNome.TabIndex = 2;
            // 
            // lblFiltroNome
            // 
            this.lblFiltroNome.AutoSize = true;
            this.lblFiltroNome.Location = new System.Drawing.Point(16, 60);
            this.lblFiltroNome.Name = "lblFiltroNome";
            this.lblFiltroNome.Size = new System.Drawing.Size(41, 13);
            this.lblFiltroNome.TabIndex = 1;
            this.lblFiltroNome.Text = "Nome: ";
            // 
            // lblFiltroDataConsulta
            // 
            this.lblFiltroDataConsulta.AutoSize = true;
            this.lblFiltroDataConsulta.Location = new System.Drawing.Point(16, 33);
            this.lblFiltroDataConsulta.Name = "lblFiltroDataConsulta";
            this.lblFiltroDataConsulta.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroDataConsulta.TabIndex = 0;
            this.lblFiltroDataConsulta.Text = "Data Consulta: ";
            // 
            // btConfirmarPaciente
            // 
            this.btConfirmarPaciente.Location = new System.Drawing.Point(417, 451);
            this.btConfirmarPaciente.Name = "btConfirmarPaciente";
            this.btConfirmarPaciente.Size = new System.Drawing.Size(198, 25);
            this.btConfirmarPaciente.TabIndex = 3;
            this.btConfirmarPaciente.Text = "Confirmar Paciente";
            this.btConfirmarPaciente.UseVisualStyleBackColor = true;
            this.btConfirmarPaciente.Click += new System.EventHandler(this.btConfirmarPaciente_Click);
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
            // gbDadosPaciente
            // 
            this.gbDadosPaciente.Controls.Add(this.gbTriagem);
            this.gbDadosPaciente.Controls.Add(this.lblSexo);
            this.gbDadosPaciente.Controls.Add(this.lblNomePai);
            this.gbDadosPaciente.Controls.Add(this.lblNomeMae);
            this.gbDadosPaciente.Controls.Add(this.lblDataNascimento);
            this.gbDadosPaciente.Controls.Add(this.lblNomePaciente);
            this.gbDadosPaciente.Location = new System.Drawing.Point(309, 137);
            this.gbDadosPaciente.Name = "gbDadosPaciente";
            this.gbDadosPaciente.Size = new System.Drawing.Size(398, 308);
            this.gbDadosPaciente.TabIndex = 5;
            this.gbDadosPaciente.TabStop = false;
            this.gbDadosPaciente.Text = "Dados do Paciente";
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
            // lvPacienteTriagem
            // 
            this.lvPacienteTriagem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataConsulta,
            this.NumeroProntuario,
            this.EnfermeiroID,
            this.EnfermeiroNome,
            this.PacienteID,
            this.PacienteNome,
            this.PacienteDN,
            this.PacienteNomeMae,
            this.PacienteNomePai,
            this.DadosVitaisID,
            this.DVpressao,
            this.DVpulso,
            this.DVtemperatura,
            this.DVrespiracao});
            this.lvPacienteTriagem.FullRowSelect = true;
            this.lvPacienteTriagem.Location = new System.Drawing.Point(21, 137);
            this.lvPacienteTriagem.MultiSelect = false;
            this.lvPacienteTriagem.Name = "lvPacienteTriagem";
            this.lvPacienteTriagem.Size = new System.Drawing.Size(262, 308);
            this.lvPacienteTriagem.TabIndex = 6;
            this.lvPacienteTriagem.UseCompatibleStateImageBehavior = false;
            this.lvPacienteTriagem.View = System.Windows.Forms.View.Details;
            this.lvPacienteTriagem.SelectedIndexChanged += new System.EventHandler(this.lvPacienteTriagem_SelectedIndexChanged);
            // 
            // DataConsulta
            // 
            this.DataConsulta.Text = "Data Consulta";
            this.DataConsulta.Width = 85;
            // 
            // NumeroProntuario
            // 
            this.NumeroProntuario.Text = "Número Prontuário";
            this.NumeroProntuario.Width = 0;
            // 
            // EnfermeiroID
            // 
            this.EnfermeiroID.Text = "EnfermeiroID";
            this.EnfermeiroID.Width = 0;
            // 
            // EnfermeiroNome
            // 
            this.EnfermeiroNome.Text = "Enfermeiro";
            this.EnfermeiroNome.Width = 0;
            // 
            // PacienteID
            // 
            this.PacienteID.Text = "PacienteID";
            this.PacienteID.Width = 0;
            // 
            // PacienteNome
            // 
            this.PacienteNome.Text = "Paciente";
            this.PacienteNome.Width = 171;
            // 
            // PacienteDN
            // 
            this.PacienteDN.Text = "Data de Nascimento";
            this.PacienteDN.Width = 0;
            // 
            // PacienteNomeMae
            // 
            this.PacienteNomeMae.Text = "Nome da Mãe";
            this.PacienteNomeMae.Width = 0;
            // 
            // PacienteNomePai
            // 
            this.PacienteNomePai.Text = "Nome do Pai";
            this.PacienteNomePai.Width = 0;
            // 
            // DadosVitaisID
            // 
            this.DadosVitaisID.Text = "DadosVitaisID";
            this.DadosVitaisID.Width = 0;
            // 
            // DVpressao
            // 
            this.DVpressao.Text = "Pressão";
            this.DVpressao.Width = 0;
            // 
            // DVpulso
            // 
            this.DVpulso.Text = "Pulso";
            this.DVpulso.Width = 0;
            // 
            // DVtemperatura
            // 
            this.DVtemperatura.Text = "Temperatura";
            this.DVtemperatura.Width = 0;
            // 
            // DVrespiracao
            // 
            this.DVrespiracao.Text = "Respiração";
            this.DVrespiracao.Width = 0;
            // 
            // FormConsultarPacienteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 488);
            this.Controls.Add(this.lvPacienteTriagem);
            this.Controls.Add(this.gbDadosPaciente);
            this.Controls.Add(this.btConfirmarPaciente);
            this.Controls.Add(this.gbBuscaFiltroPaciente);
            this.Name = "FormConsultarPacienteMedico";
            this.Text = "Consultar Paciente - Medico";
            this.gbBuscaFiltroPaciente.ResumeLayout(false);
            this.gbBuscaFiltroPaciente.PerformLayout();
            this.gbDadosPaciente.ResumeLayout(false);
            this.gbDadosPaciente.PerformLayout();
            this.gbTriagem.ResumeLayout(false);
            this.gbTriagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscaFiltroPaciente;
        private System.Windows.Forms.Label lblFiltroNome;
        private System.Windows.Forms.Label lblFiltroDataConsulta;
        private System.Windows.Forms.Button btConfirmarPaciente;
        private System.Windows.Forms.Button btBuscarPaciente;
        private System.Windows.Forms.DateTimePicker dpFiltroDataConsulta;
        private System.Windows.Forms.TextBox txtBoxFiltroNome;
        private System.Windows.Forms.Label lblNomePaciente;
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
        private System.Windows.Forms.ListView lvPacienteTriagem;
        private System.Windows.Forms.ColumnHeader NumeroProntuario;
        private System.Windows.Forms.ColumnHeader EnfermeiroID;
        private System.Windows.Forms.ColumnHeader EnfermeiroNome;
        private System.Windows.Forms.ColumnHeader PacienteID;
        private System.Windows.Forms.ColumnHeader PacienteNome;
        private System.Windows.Forms.ColumnHeader PacienteDN;
        private System.Windows.Forms.ColumnHeader PacienteNomeMae;
        private System.Windows.Forms.ColumnHeader PacienteNomePai;
        private System.Windows.Forms.ColumnHeader DadosVitaisID;
        private System.Windows.Forms.ColumnHeader DVpressao;
        private System.Windows.Forms.ColumnHeader DVpulso;
        private System.Windows.Forms.ColumnHeader DVtemperatura;
        private System.Windows.Forms.ColumnHeader DVrespiracao;
        private System.Windows.Forms.ColumnHeader DataConsulta;
    }
}