namespace IMedico
{
    partial class FormGerarReceita
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
            this.btAdicionarMedicamento = new System.Windows.Forms.Button();
            this.gbFiltroMedicamentos = new System.Windows.Forms.GroupBox();
            this.lblListaMedicamentosRetorno = new System.Windows.Forms.Label();
            this.txtBoxNomeGenerico = new System.Windows.Forms.TextBox();
            this.txtBoxNomeComercial = new System.Windows.Forms.TextBox();
            this.txtBoxCategoria = new System.Windows.Forms.TextBox();
            this.lblFiltroNomeGenerico = new System.Windows.Forms.Label();
            this.lblFiltroNomeComercial = new System.Windows.Forms.Label();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.lvListaMedicamentosRetorno = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeGenerico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Composicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indicacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContraIndicacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btListar = new System.Windows.Forms.Button();
            this.gbInfoMedicamento = new System.Windows.Forms.GroupBox();
            this.lblReceitaParcial = new System.Windows.Forms.Label();
            this.txtBoxInstrucoes = new System.Windows.Forms.TextBox();
            this.txtBoxTempoTratamento = new System.Windows.Forms.TextBox();
            this.txtBoxDosagem = new System.Windows.Forms.TextBox();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.lblTempoTratamento = new System.Windows.Forms.Label();
            this.lblDosagemReceita = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblIndicacoes = new System.Windows.Forms.Label();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.lblDosagem = new System.Windows.Forms.Label();
            this.lblComposicao = new System.Windows.Forms.Label();
            this.lblNomeComercial = new System.Windows.Forms.Label();
            this.lblNomeGenerico = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btGerarReceita = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvReceitaParcial = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Instruções = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceitaDosagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFiltroMedicamentos.SuspendLayout();
            this.gbInfoMedicamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionarMedicamento
            // 
            this.btAdicionarMedicamento.Location = new System.Drawing.Point(219, 213);
            this.btAdicionarMedicamento.Name = "btAdicionarMedicamento";
            this.btAdicionarMedicamento.Size = new System.Drawing.Size(335, 46);
            this.btAdicionarMedicamento.TabIndex = 2;
            this.btAdicionarMedicamento.Text = "Adicionar Medicamento";
            this.btAdicionarMedicamento.UseVisualStyleBackColor = true;
            this.btAdicionarMedicamento.Click += new System.EventHandler(this.btAdicionarMedicamento_Click);
            // 
            // gbFiltroMedicamentos
            // 
            this.gbFiltroMedicamentos.Controls.Add(this.lblListaMedicamentosRetorno);
            this.gbFiltroMedicamentos.Controls.Add(this.txtBoxNomeGenerico);
            this.gbFiltroMedicamentos.Controls.Add(this.txtBoxNomeComercial);
            this.gbFiltroMedicamentos.Controls.Add(this.txtBoxCategoria);
            this.gbFiltroMedicamentos.Controls.Add(this.lblFiltroNomeGenerico);
            this.gbFiltroMedicamentos.Controls.Add(this.lblFiltroNomeComercial);
            this.gbFiltroMedicamentos.Controls.Add(this.lblFiltroCategoria);
            this.gbFiltroMedicamentos.Controls.Add(this.lvListaMedicamentosRetorno);
            this.gbFiltroMedicamentos.Controls.Add(this.btListar);
            this.gbFiltroMedicamentos.Location = new System.Drawing.Point(18, 12);
            this.gbFiltroMedicamentos.Name = "gbFiltroMedicamentos";
            this.gbFiltroMedicamentos.Size = new System.Drawing.Size(371, 456);
            this.gbFiltroMedicamentos.TabIndex = 3;
            this.gbFiltroMedicamentos.TabStop = false;
            this.gbFiltroMedicamentos.Text = "Busca Medicamentos: preencha os filtros desejados";
            // 
            // lblListaMedicamentosRetorno
            // 
            this.lblListaMedicamentosRetorno.AutoSize = true;
            this.lblListaMedicamentosRetorno.Location = new System.Drawing.Point(19, 159);
            this.lblListaMedicamentosRetorno.Name = "lblListaMedicamentosRetorno";
            this.lblListaMedicamentosRetorno.Size = new System.Drawing.Size(303, 13);
            this.lblListaMedicamentosRetorno.TabIndex = 15;
            this.lblListaMedicamentosRetorno.Text = "Retorno: Lista de Medicamentos - Selecione uma linha da lista:";
            // 
            // txtBoxNomeGenerico
            // 
            this.txtBoxNomeGenerico.Location = new System.Drawing.Point(107, 72);
            this.txtBoxNomeGenerico.Name = "txtBoxNomeGenerico";
            this.txtBoxNomeGenerico.Size = new System.Drawing.Size(238, 20);
            this.txtBoxNomeGenerico.TabIndex = 14;
            // 
            // txtBoxNomeComercial
            // 
            this.txtBoxNomeComercial.Location = new System.Drawing.Point(115, 46);
            this.txtBoxNomeComercial.Name = "txtBoxNomeComercial";
            this.txtBoxNomeComercial.Size = new System.Drawing.Size(230, 20);
            this.txtBoxNomeComercial.TabIndex = 13;
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.Location = new System.Drawing.Point(83, 20);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(262, 20);
            this.txtBoxCategoria.TabIndex = 12;
            // 
            // lblFiltroNomeGenerico
            // 
            this.lblFiltroNomeGenerico.AutoSize = true;
            this.lblFiltroNomeGenerico.Location = new System.Drawing.Point(19, 75);
            this.lblFiltroNomeGenerico.Name = "lblFiltroNomeGenerico";
            this.lblFiltroNomeGenerico.Size = new System.Drawing.Size(87, 13);
            this.lblFiltroNomeGenerico.TabIndex = 11;
            this.lblFiltroNomeGenerico.Text = "Nome Genérico: ";
            // 
            // lblFiltroNomeComercial
            // 
            this.lblFiltroNomeComercial.AutoSize = true;
            this.lblFiltroNomeComercial.Location = new System.Drawing.Point(19, 51);
            this.lblFiltroNomeComercial.Name = "lblFiltroNomeComercial";
            this.lblFiltroNomeComercial.Size = new System.Drawing.Size(90, 13);
            this.lblFiltroNomeComercial.TabIndex = 10;
            this.lblFiltroNomeComercial.Text = "Nome Comercial: ";
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(19, 23);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblFiltroCategoria.TabIndex = 9;
            this.lblFiltroCategoria.Text = "Categoria: ";
            // 
            // lvListaMedicamentosRetorno
            // 
            this.lvListaMedicamentosRetorno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Tipo,
            this.NomeGenerico,
            this.NomeComercial,
            this.Composicao,
            this.Dosagem,
            this.Indicacoes,
            this.ContraIndicacoes,
            this.Fabricante});
            this.lvListaMedicamentosRetorno.FullRowSelect = true;
            this.lvListaMedicamentosRetorno.Location = new System.Drawing.Point(20, 175);
            this.lvListaMedicamentosRetorno.MultiSelect = false;
            this.lvListaMedicamentosRetorno.Name = "lvListaMedicamentosRetorno";
            this.lvListaMedicamentosRetorno.Size = new System.Drawing.Size(323, 255);
            this.lvListaMedicamentosRetorno.TabIndex = 6;
            this.lvListaMedicamentosRetorno.UseCompatibleStateImageBehavior = false;
            this.lvListaMedicamentosRetorno.View = System.Windows.Forms.View.Details;
            this.lvListaMedicamentosRetorno.SelectedIndexChanged += new System.EventHandler(this.lvListaMedicamentosRetorno_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            // 
            // NomeGenerico
            // 
            this.NomeGenerico.Text = "Nome Genérico";
            // 
            // NomeComercial
            // 
            this.NomeComercial.Text = "Nome Comercial";
            // 
            // Composicao
            // 
            this.Composicao.Text = "Composição";
            // 
            // Dosagem
            // 
            this.Dosagem.Text = "Dosagem";
            // 
            // Indicacoes
            // 
            this.Indicacoes.Text = "Indicações";
            // 
            // ContraIndicacoes
            // 
            this.ContraIndicacoes.Text = "Contra-indicações";
            // 
            // Fabricante
            // 
            this.Fabricante.Text = "Fabricante";
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(20, 100);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(325, 40);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // gbInfoMedicamento
            // 
            this.gbInfoMedicamento.Controls.Add(this.lvReceitaParcial);
            this.gbInfoMedicamento.Controls.Add(this.lblReceitaParcial);
            this.gbInfoMedicamento.Controls.Add(this.txtBoxInstrucoes);
            this.gbInfoMedicamento.Controls.Add(this.txtBoxTempoTratamento);
            this.gbInfoMedicamento.Controls.Add(this.txtBoxDosagem);
            this.gbInfoMedicamento.Controls.Add(this.txtBoxQuantidade);
            this.gbInfoMedicamento.Controls.Add(this.lblInstrucoes);
            this.gbInfoMedicamento.Controls.Add(this.lblTempoTratamento);
            this.gbInfoMedicamento.Controls.Add(this.lblDosagemReceita);
            this.gbInfoMedicamento.Controls.Add(this.lblQuantidade);
            this.gbInfoMedicamento.Controls.Add(this.lblFabricante);
            this.gbInfoMedicamento.Controls.Add(this.lblIndicacoes);
            this.gbInfoMedicamento.Controls.Add(this.lblContraIndicacoes);
            this.gbInfoMedicamento.Controls.Add(this.lblDosagem);
            this.gbInfoMedicamento.Controls.Add(this.lblComposicao);
            this.gbInfoMedicamento.Controls.Add(this.lblNomeComercial);
            this.gbInfoMedicamento.Controls.Add(this.lblNomeGenerico);
            this.gbInfoMedicamento.Controls.Add(this.lblTipo);
            this.gbInfoMedicamento.Controls.Add(this.button1);
            this.gbInfoMedicamento.Controls.Add(this.btGerarReceita);
            this.gbInfoMedicamento.Controls.Add(this.btAdicionarMedicamento);
            this.gbInfoMedicamento.Location = new System.Drawing.Point(415, 12);
            this.gbInfoMedicamento.Name = "gbInfoMedicamento";
            this.gbInfoMedicamento.Size = new System.Drawing.Size(796, 459);
            this.gbInfoMedicamento.TabIndex = 4;
            this.gbInfoMedicamento.TabStop = false;
            this.gbInfoMedicamento.Text = "Informações do Medicamento - Código: ";
            // 
            // lblReceitaParcial
            // 
            this.lblReceitaParcial.AutoSize = true;
            this.lblReceitaParcial.Location = new System.Drawing.Point(350, 268);
            this.lblReceitaParcial.Name = "lblReceitaParcial";
            this.lblReceitaParcial.Size = new System.Drawing.Size(85, 13);
            this.lblReceitaParcial.TabIndex = 23;
            this.lblReceitaParcial.Text = "Receita Parcial: ";
            // 
            // txtBoxInstrucoes
            // 
            this.txtBoxInstrucoes.Location = new System.Drawing.Point(561, 107);
            this.txtBoxInstrucoes.Multiline = true;
            this.txtBoxInstrucoes.Name = "txtBoxInstrucoes";
            this.txtBoxInstrucoes.Size = new System.Drawing.Size(221, 84);
            this.txtBoxInstrucoes.TabIndex = 22;
            // 
            // txtBoxTempoTratamento
            // 
            this.txtBoxTempoTratamento.Location = new System.Drawing.Point(682, 62);
            this.txtBoxTempoTratamento.Name = "txtBoxTempoTratamento";
            this.txtBoxTempoTratamento.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTempoTratamento.TabIndex = 21;
            // 
            // txtBoxDosagem
            // 
            this.txtBoxDosagem.Location = new System.Drawing.Point(632, 40);
            this.txtBoxDosagem.Name = "txtBoxDosagem";
            this.txtBoxDosagem.Size = new System.Drawing.Size(150, 20);
            this.txtBoxDosagem.TabIndex = 20;
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(632, 18);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(150, 20);
            this.txtBoxQuantidade.TabIndex = 19;
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Location = new System.Drawing.Point(558, 86);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(62, 13);
            this.lblInstrucoes.TabIndex = 18;
            this.lblInstrucoes.Text = "Instruções: ";
            // 
            // lblTempoTratamento
            // 
            this.lblTempoTratamento.AutoSize = true;
            this.lblTempoTratamento.Location = new System.Drawing.Point(558, 65);
            this.lblTempoTratamento.Name = "lblTempoTratamento";
            this.lblTempoTratamento.Size = new System.Drawing.Size(118, 13);
            this.lblTempoTratamento.TabIndex = 17;
            this.lblTempoTratamento.Text = "Tempo de Tratamento: ";
            // 
            // lblDosagemReceita
            // 
            this.lblDosagemReceita.AutoSize = true;
            this.lblDosagemReceita.Location = new System.Drawing.Point(558, 44);
            this.lblDosagemReceita.Name = "lblDosagemReceita";
            this.lblDosagemReceita.Size = new System.Drawing.Size(58, 13);
            this.lblDosagemReceita.TabIndex = 16;
            this.lblDosagemReceita.Text = "Dosagem: ";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(558, 23);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lblQuantidade.TabIndex = 15;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(17, 172);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(63, 13);
            this.lblFabricante.TabIndex = 14;
            this.lblFabricante.Text = "Fabricante: ";
            // 
            // lblIndicacoes
            // 
            this.lblIndicacoes.AutoSize = true;
            this.lblIndicacoes.Location = new System.Drawing.Point(17, 151);
            this.lblIndicacoes.Name = "lblIndicacoes";
            this.lblIndicacoes.Size = new System.Drawing.Size(65, 13);
            this.lblIndicacoes.TabIndex = 13;
            this.lblIndicacoes.Text = "Indicações: ";
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Location = new System.Drawing.Point(17, 130);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(92, 13);
            this.lblContraIndicacoes.TabIndex = 12;
            this.lblContraIndicacoes.Text = "Contra-indicações";
            // 
            // lblDosagem
            // 
            this.lblDosagem.AutoSize = true;
            this.lblDosagem.Location = new System.Drawing.Point(17, 109);
            this.lblDosagem.Name = "lblDosagem";
            this.lblDosagem.Size = new System.Drawing.Size(58, 13);
            this.lblDosagem.TabIndex = 11;
            this.lblDosagem.Text = "Dosagem: ";
            // 
            // lblComposicao
            // 
            this.lblComposicao.AutoSize = true;
            this.lblComposicao.Location = new System.Drawing.Point(17, 88);
            this.lblComposicao.Name = "lblComposicao";
            this.lblComposicao.Size = new System.Drawing.Size(71, 13);
            this.lblComposicao.TabIndex = 10;
            this.lblComposicao.Text = "Composição: ";
            // 
            // lblNomeComercial
            // 
            this.lblNomeComercial.AutoSize = true;
            this.lblNomeComercial.Location = new System.Drawing.Point(17, 67);
            this.lblNomeComercial.Name = "lblNomeComercial";
            this.lblNomeComercial.Size = new System.Drawing.Size(90, 13);
            this.lblNomeComercial.TabIndex = 9;
            this.lblNomeComercial.Text = "Nome Comercial: ";
            // 
            // lblNomeGenerico
            // 
            this.lblNomeGenerico.AutoSize = true;
            this.lblNomeGenerico.Location = new System.Drawing.Point(17, 46);
            this.lblNomeGenerico.Name = "lblNomeGenerico";
            this.lblNomeGenerico.Size = new System.Drawing.Size(87, 13);
            this.lblNomeGenerico.TabIndex = 8;
            this.lblNomeGenerico.Text = "Nome Genérico: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 25);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo: ";
            // 
            // btGerarReceita
            // 
            this.btGerarReceita.Location = new System.Drawing.Point(219, 424);
            this.btGerarReceita.Name = "btGerarReceita";
            this.btGerarReceita.Size = new System.Drawing.Size(335, 35);
            this.btGerarReceita.TabIndex = 4;
            this.btGerarReceita.Text = "Gerar Receita";
            this.btGerarReceita.UseVisualStyleBackColor = true;
            this.btGerarReceita.Click += new System.EventHandler(this.btGerarReceita_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvReceitaParcial
            // 
            this.lvReceitaParcial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.ReceitaDosagem,
            this.Quantidade,
            this.Tempo,
            this.Instruções});
            this.lvReceitaParcial.Location = new System.Drawing.Point(219, 284);
            this.lvReceitaParcial.MultiSelect = false;
            this.lvReceitaParcial.Name = "lvReceitaParcial";
            this.lvReceitaParcial.Size = new System.Drawing.Size(335, 134);
            this.lvReceitaParcial.TabIndex = 24;
            this.lvReceitaParcial.UseCompatibleStateImageBehavior = false;
            this.lvReceitaParcial.View = System.Windows.Forms.View.Details;
            this.lvReceitaParcial.SelectedIndexChanged += new System.EventHandler(this.lvReceitaParcial_SelectedIndexChanged);
            // 
            // Código
            // 
            this.Código.Text = "Código";
            // 
            // Quantidade
            // 
            this.Quantidade.DisplayIndex = 1;
            this.Quantidade.Text = "Quantidade";
            // 
            // Tempo
            // 
            this.Tempo.DisplayIndex = 2;
            this.Tempo.Text = "Tempo de Tratamento";
            // 
            // Instruções
            // 
            this.Instruções.DisplayIndex = 3;
            this.Instruções.Text = "Instruções";
            // 
            // ReceitaDosagem
            // 
            this.ReceitaDosagem.Text = "Dosagem";
            // 
            // FormGerarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1322, 524);
            this.Controls.Add(this.gbInfoMedicamento);
            this.Controls.Add(this.gbFiltroMedicamentos);
            this.Name = "FormGerarReceita";
            this.Text = "Gerar Receita";
            this.gbFiltroMedicamentos.ResumeLayout(false);
            this.gbFiltroMedicamentos.PerformLayout();
            this.gbInfoMedicamento.ResumeLayout(false);
            this.gbInfoMedicamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionarMedicamento;
        private System.Windows.Forms.GroupBox gbFiltroMedicamentos;
        private System.Windows.Forms.ListView lvListaMedicamentosRetorno;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.GroupBox gbInfoMedicamento;
        private System.Windows.Forms.Button btGerarReceita;
        private System.Windows.Forms.TextBox txtBoxNomeGenerico;
        private System.Windows.Forms.TextBox txtBoxNomeComercial;
        private System.Windows.Forms.TextBox txtBoxCategoria;
        private System.Windows.Forms.Label lblFiltroNomeGenerico;
        private System.Windows.Forms.Label lblFiltroNomeComercial;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Label lblListaMedicamentosRetorno;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader NomeGenerico;
        private System.Windows.Forms.ColumnHeader NomeComercial;
        private System.Windows.Forms.ColumnHeader Composicao;
        private System.Windows.Forms.ColumnHeader Dosagem;
        private System.Windows.Forms.ColumnHeader Indicacoes;
        private System.Windows.Forms.ColumnHeader ContraIndicacoes;
        private System.Windows.Forms.ColumnHeader Fabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblIndicacoes;
        private System.Windows.Forms.Label lblContraIndicacoes;
        private System.Windows.Forms.Label lblDosagem;
        private System.Windows.Forms.Label lblComposicao;
        private System.Windows.Forms.Label lblNomeComercial;
        private System.Windows.Forms.Label lblNomeGenerico;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblReceitaParcial;
        private System.Windows.Forms.TextBox txtBoxInstrucoes;
        private System.Windows.Forms.TextBox txtBoxTempoTratamento;
        private System.Windows.Forms.TextBox txtBoxDosagem;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private System.Windows.Forms.Label lblInstrucoes;
        private System.Windows.Forms.Label lblTempoTratamento;
        private System.Windows.Forms.Label lblDosagemReceita;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ListView lvReceitaParcial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Tempo;
        private System.Windows.Forms.ColumnHeader Instruções;
        private System.Windows.Forms.ColumnHeader ReceitaDosagem;
    }
}