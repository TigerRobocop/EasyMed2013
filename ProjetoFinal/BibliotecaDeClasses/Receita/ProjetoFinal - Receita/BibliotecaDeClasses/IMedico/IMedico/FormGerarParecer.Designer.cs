namespace IMedico
{
    partial class FormGerarParecer
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
            this.btFormGerarAtestado = new System.Windows.Forms.Button();
            this.btFormGerarReceita = new System.Windows.Forms.Button();
            this.txtBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.gbDadosPaciente = new System.Windows.Forms.GroupBox();
            this.gbDadosMedico = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.btFinalizarConsulta = new System.Windows.Forms.Button();
            this.lblReceitaGerada = new System.Windows.Forms.Label();
            this.gbDadosPaciente.SuspendLayout();
            this.gbDadosMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFormGerarAtestado
            // 
            this.btFormGerarAtestado.Location = new System.Drawing.Point(30, 295);
            this.btFormGerarAtestado.Name = "btFormGerarAtestado";
            this.btFormGerarAtestado.Size = new System.Drawing.Size(194, 34);
            this.btFormGerarAtestado.TabIndex = 8;
            this.btFormGerarAtestado.Text = "Gerar Atestado";
            this.btFormGerarAtestado.UseVisualStyleBackColor = true;
            this.btFormGerarAtestado.Click += new System.EventHandler(this.btFormGerarAtestado_Click);
            // 
            // btFormGerarReceita
            // 
            this.btFormGerarReceita.Location = new System.Drawing.Point(234, 295);
            this.btFormGerarReceita.Name = "btFormGerarReceita";
            this.btFormGerarReceita.Size = new System.Drawing.Size(194, 34);
            this.btFormGerarReceita.TabIndex = 7;
            this.btFormGerarReceita.Text = "Gerar Receita";
            this.btFormGerarReceita.UseVisualStyleBackColor = true;
            this.btFormGerarReceita.Click += new System.EventHandler(this.btFormGerarReceita_Click);
            // 
            // txtBoxDiagnostico
            // 
            this.txtBoxDiagnostico.Location = new System.Drawing.Point(452, 47);
            this.txtBoxDiagnostico.Multiline = true;
            this.txtBoxDiagnostico.Name = "txtBoxDiagnostico";
            this.txtBoxDiagnostico.Size = new System.Drawing.Size(301, 186);
            this.txtBoxDiagnostico.TabIndex = 10;
            // 
            // gbDadosPaciente
            // 
            this.gbDadosPaciente.Controls.Add(this.gbDadosMedico);
            this.gbDadosPaciente.Controls.Add(this.lblSexo);
            this.gbDadosPaciente.Controls.Add(this.lblNomePai);
            this.gbDadosPaciente.Controls.Add(this.lblNomeMae);
            this.gbDadosPaciente.Controls.Add(this.lblDataNascimento);
            this.gbDadosPaciente.Controls.Add(this.lblNomePaciente);
            this.gbDadosPaciente.Location = new System.Drawing.Point(30, 31);
            this.gbDadosPaciente.Name = "gbDadosPaciente";
            this.gbDadosPaciente.Size = new System.Drawing.Size(398, 244);
            this.gbDadosPaciente.TabIndex = 13;
            this.gbDadosPaciente.TabStop = false;
            this.gbDadosPaciente.Text = "Dados do Paciente";
            // 
            // gbDadosMedico
            // 
            this.gbDadosMedico.Controls.Add(this.label4);
            this.gbDadosMedico.Controls.Add(this.lblEspecializacao);
            this.gbDadosMedico.Controls.Add(this.lblCRM);
            this.gbDadosMedico.Controls.Add(this.lblNomeMedico);
            this.gbDadosMedico.Location = new System.Drawing.Point(18, 114);
            this.gbDadosMedico.Name = "gbDadosMedico";
            this.gbDadosMedico.Size = new System.Drawing.Size(361, 112);
            this.gbDadosMedico.TabIndex = 14;
            this.gbDadosMedico.TabStop = false;
            this.gbDadosMedico.Text = "Dados do Médico - Código: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(15, 65);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(84, 13);
            this.lblEspecializacao.TabIndex = 2;
            this.lblEspecializacao.Text = "Especialização: ";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(15, 44);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(37, 13);
            this.lblCRM.TabIndex = 1;
            this.lblCRM.Text = "CRM: ";
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(15, 23);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(94, 13);
            this.lblNomeMedico.TabIndex = 0;
            this.lblNomeMedico.Text = "Nome do Médico: ";
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
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(449, 31);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(69, 13);
            this.lblDiagnostico.TabIndex = 14;
            this.lblDiagnostico.Text = "Diagnóstico: ";
            // 
            // btFinalizarConsulta
            // 
            this.btFinalizarConsulta.Location = new System.Drawing.Point(452, 295);
            this.btFinalizarConsulta.Name = "btFinalizarConsulta";
            this.btFinalizarConsulta.Size = new System.Drawing.Size(301, 34);
            this.btFinalizarConsulta.TabIndex = 15;
            this.btFinalizarConsulta.Text = "Finalizar Consulta";
            this.btFinalizarConsulta.UseVisualStyleBackColor = true;
            this.btFinalizarConsulta.Click += new System.EventHandler(this.btFinalizarConsulta_Click);
            // 
            // lblReceitaGerada
            // 
            this.lblReceitaGerada.AutoSize = true;
            this.lblReceitaGerada.Location = new System.Drawing.Point(452, 240);
            this.lblReceitaGerada.Name = "lblReceitaGerada";
            this.lblReceitaGerada.Size = new System.Drawing.Size(0, 13);
            this.lblReceitaGerada.TabIndex = 16;
            // 
            // FormGerarParecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 350);
            this.Controls.Add(this.lblReceitaGerada);
            this.Controls.Add(this.btFinalizarConsulta);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.gbDadosPaciente);
            this.Controls.Add(this.txtBoxDiagnostico);
            this.Controls.Add(this.btFormGerarAtestado);
            this.Controls.Add(this.btFormGerarReceita);
            this.Name = "FormGerarParecer";
            this.Text = "Gerar Parecer";
            this.gbDadosPaciente.ResumeLayout(false);
            this.gbDadosPaciente.PerformLayout();
            this.gbDadosMedico.ResumeLayout(false);
            this.gbDadosMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFormGerarAtestado;
        private System.Windows.Forms.Button btFormGerarReceita;
        private System.Windows.Forms.TextBox txtBoxDiagnostico;
        private System.Windows.Forms.GroupBox gbDadosPaciente;
        private System.Windows.Forms.GroupBox gbDadosMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Button btFinalizarConsulta;
        private System.Windows.Forms.Label lblReceitaGerada;
    }
}