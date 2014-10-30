namespace IMedico
{
    partial class FormHistorico
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
            this.btHistoricoConsulta = new System.Windows.Forms.Button();
            this.lvHistoricoConsulta = new System.Windows.Forms.ListView();
            this.dataConsulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeroProntuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pacienteid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obsTriagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diagnostico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.receita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMedicamentosReceita = new System.Windows.Forms.ListView();
            this.numeroReceita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codMedicamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medNomeComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medComposicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medContraIndicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medDosagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medIndicacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medFabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recInstrucoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.redDosagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recTempoTratamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btHistoricoConsulta
            // 
            this.btHistoricoConsulta.Location = new System.Drawing.Point(111, 42);
            this.btHistoricoConsulta.Name = "btHistoricoConsulta";
            this.btHistoricoConsulta.Size = new System.Drawing.Size(208, 53);
            this.btHistoricoConsulta.TabIndex = 0;
            this.btHistoricoConsulta.Text = "Histórico de Consultas";
            this.btHistoricoConsulta.UseVisualStyleBackColor = true;
            this.btHistoricoConsulta.Click += new System.EventHandler(this.btHistoricoConsulta_Click);
            // 
            // lvHistoricoConsulta
            // 
            this.lvHistoricoConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataConsulta,
            this.numeroProntuario,
            this.pacienteid,
            this.nomePaciente,
            this.nomeMedico,
            this.obsTriagem,
            this.diagnostico,
            this.receita});
            this.lvHistoricoConsulta.FullRowSelect = true;
            this.lvHistoricoConsulta.Location = new System.Drawing.Point(22, 121);
            this.lvHistoricoConsulta.MultiSelect = false;
            this.lvHistoricoConsulta.Name = "lvHistoricoConsulta";
            this.lvHistoricoConsulta.Size = new System.Drawing.Size(383, 226);
            this.lvHistoricoConsulta.TabIndex = 2;
            this.lvHistoricoConsulta.UseCompatibleStateImageBehavior = false;
            this.lvHistoricoConsulta.View = System.Windows.Forms.View.Details;
            this.lvHistoricoConsulta.SelectedIndexChanged += new System.EventHandler(this.lvHistoricoConsulta_SelectedIndexChanged);
            // 
            // dataConsulta
            // 
            this.dataConsulta.Text = "Data Consulta";
            this.dataConsulta.Width = 81;
            // 
            // numeroProntuario
            // 
            this.numeroProntuario.Text = "Número Prontuario";
            this.numeroProntuario.Width = 0;
            // 
            // pacienteid
            // 
            this.pacienteid.Text = "PacienteID";
            this.pacienteid.Width = 0;
            // 
            // nomePaciente
            // 
            this.nomePaciente.Text = "Paciente";
            this.nomePaciente.Width = 0;
            // 
            // nomeMedico
            // 
            this.nomeMedico.Text = "Médico";
            this.nomeMedico.Width = 104;
            // 
            // obsTriagem
            // 
            this.obsTriagem.Text = "Obs. Triagem";
            this.obsTriagem.Width = 0;
            // 
            // diagnostico
            // 
            this.diagnostico.Text = "Diagnóstico";
            this.diagnostico.Width = 126;
            // 
            // receita
            // 
            this.receita.Text = "Receita";
            // 
            // lvMedicamentosReceita
            // 
            this.lvMedicamentosReceita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numeroReceita,
            this.idPaciente,
            this.codMedicamento,
            this.medNomeComercial,
            this.medComposicao,
            this.medContraIndicacao,
            this.medDosagem,
            this.medIndicacoes,
            this.medFabricante,
            this.recInstrucoes,
            this.recQuantidade,
            this.redDosagem,
            this.recTempoTratamento});
            this.lvMedicamentosReceita.FullRowSelect = true;
            this.lvMedicamentosReceita.Location = new System.Drawing.Point(481, 121);
            this.lvMedicamentosReceita.MultiSelect = false;
            this.lvMedicamentosReceita.Name = "lvMedicamentosReceita";
            this.lvMedicamentosReceita.Size = new System.Drawing.Size(560, 226);
            this.lvMedicamentosReceita.TabIndex = 3;
            this.lvMedicamentosReceita.UseCompatibleStateImageBehavior = false;
            this.lvMedicamentosReceita.View = System.Windows.Forms.View.Details;
            this.lvMedicamentosReceita.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvMedicamentosReceita_ColumnWidthChanging);
            // 
            // numeroReceita
            // 
            this.numeroReceita.Text = "Número Receita";
            this.numeroReceita.Width = 0;
            // 
            // idPaciente
            // 
            this.idPaciente.Text = "id Paciente";
            this.idPaciente.Width = 0;
            // 
            // codMedicamento
            // 
            this.codMedicamento.Text = "Código Medicamento";
            this.codMedicamento.Width = 0;
            // 
            // medNomeComercial
            // 
            this.medNomeComercial.Text = "Nome Comercial";
            this.medNomeComercial.Width = 114;
            // 
            // medComposicao
            // 
            this.medComposicao.Text = "Composição";
            this.medComposicao.Width = 0;
            // 
            // medContraIndicacao
            // 
            this.medContraIndicacao.Text = "Contra-indicações";
            this.medContraIndicacao.Width = 0;
            // 
            // medDosagem
            // 
            this.medDosagem.Text = "Dosagem Indicada";
            this.medDosagem.Width = 0;
            // 
            // medIndicacoes
            // 
            this.medIndicacoes.Text = "Indicações";
            this.medIndicacoes.Width = 0;
            // 
            // medFabricante
            // 
            this.medFabricante.Text = "Fabricante";
            this.medFabricante.Width = 0;
            // 
            // recInstrucoes
            // 
            this.recInstrucoes.Text = "Instruções Receita";
            this.recInstrucoes.Width = 121;
            // 
            // recQuantidade
            // 
            this.recQuantidade.Text = "Quantidade Receita";
            this.recQuantidade.Width = 111;
            // 
            // redDosagem
            // 
            this.redDosagem.Text = "Dosagem Receita";
            this.redDosagem.Width = 99;
            // 
            // recTempoTratamento
            // 
            this.recTempoTratamento.Text = "Tempo Tratamento";
            this.recTempoTratamento.Width = 108;
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 493);
            this.Controls.Add(this.lvMedicamentosReceita);
            this.Controls.Add(this.lvHistoricoConsulta);
            this.Controls.Add(this.btHistoricoConsulta);
            this.Name = "FormHistorico";
            this.Text = "Histórico do Paciente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHistoricoConsulta;
        private System.Windows.Forms.ListView lvHistoricoConsulta;
        private System.Windows.Forms.ColumnHeader dataConsulta;
        private System.Windows.Forms.ColumnHeader numeroProntuario;
        private System.Windows.Forms.ColumnHeader nomePaciente;
        private System.Windows.Forms.ColumnHeader nomeMedico;
        private System.Windows.Forms.ColumnHeader obsTriagem;
        private System.Windows.Forms.ColumnHeader diagnostico;
        private System.Windows.Forms.ColumnHeader receita;
        private System.Windows.Forms.ListView lvMedicamentosReceita;
        private System.Windows.Forms.ColumnHeader numeroReceita;
        private System.Windows.Forms.ColumnHeader idPaciente;
        private System.Windows.Forms.ColumnHeader codMedicamento;
        private System.Windows.Forms.ColumnHeader medNomeComercial;
        private System.Windows.Forms.ColumnHeader medComposicao;
        private System.Windows.Forms.ColumnHeader medContraIndicacao;
        private System.Windows.Forms.ColumnHeader medDosagem;
        private System.Windows.Forms.ColumnHeader medIndicacoes;
        private System.Windows.Forms.ColumnHeader medFabricante;
        private System.Windows.Forms.ColumnHeader recInstrucoes;
        private System.Windows.Forms.ColumnHeader recQuantidade;
        private System.Windows.Forms.ColumnHeader redDosagem;
        private System.Windows.Forms.ColumnHeader recTempoTratamento;
        private System.Windows.Forms.ColumnHeader pacienteid;
    }
}