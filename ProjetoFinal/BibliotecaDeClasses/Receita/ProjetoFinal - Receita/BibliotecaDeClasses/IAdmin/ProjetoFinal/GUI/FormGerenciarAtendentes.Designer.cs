﻿namespace IAdmin.GUI
{
    partial class FormGerenciarAtendentes
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
            this.btCadastrarNovo = new System.Windows.Forms.Button();
            this.gbFiltrosBusca = new System.Windows.Forms.GroupBox();
            this.btBuscaFiltro = new System.Windows.Forms.Button();
            this.txtBoxFiltroNome = new System.Windows.Forms.TextBox();
            this.txtBoxFiltroRG = new System.Windows.Forms.TextBox();
            this.txtBoxFiltroMatricula = new System.Windows.Forms.TextBox();
            this.lblFiltroNome = new System.Windows.Forms.Label();
            this.lblFiltroRG = new System.Windows.Forms.Label();
            this.lblFiltroMatricula = new System.Windows.Forms.Label();
            this.lvAtendentes = new System.Windows.Forms.ListView();
            this.Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btListarTodos = new System.Windows.Forms.Button();
            this.btEditarDados = new System.Windows.Forms.Button();
            this.btExcluirCadastro = new System.Windows.Forms.Button();
            this.gbFiltrosBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrarNovo
            // 
            this.btCadastrarNovo.Location = new System.Drawing.Point(19, 29);
            this.btCadastrarNovo.Name = "btCadastrarNovo";
            this.btCadastrarNovo.Size = new System.Drawing.Size(199, 55);
            this.btCadastrarNovo.TabIndex = 0;
            this.btCadastrarNovo.Text = "Cadastrar Novo";
            this.btCadastrarNovo.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosBusca
            // 
            this.gbFiltrosBusca.Controls.Add(this.btBuscaFiltro);
            this.gbFiltrosBusca.Controls.Add(this.txtBoxFiltroNome);
            this.gbFiltrosBusca.Controls.Add(this.txtBoxFiltroRG);
            this.gbFiltrosBusca.Controls.Add(this.txtBoxFiltroMatricula);
            this.gbFiltrosBusca.Controls.Add(this.lblFiltroNome);
            this.gbFiltrosBusca.Controls.Add(this.lblFiltroRG);
            this.gbFiltrosBusca.Controls.Add(this.lblFiltroMatricula);
            this.gbFiltrosBusca.Location = new System.Drawing.Point(245, 15);
            this.gbFiltrosBusca.Name = "gbFiltrosBusca";
            this.gbFiltrosBusca.Size = new System.Drawing.Size(377, 106);
            this.gbFiltrosBusca.TabIndex = 1;
            this.gbFiltrosBusca.TabStop = false;
            this.gbFiltrosBusca.Text = "Busca: Preencha os filtros desejados";
            // 
            // btBuscaFiltro
            // 
            this.btBuscaFiltro.Location = new System.Drawing.Point(222, 19);
            this.btBuscaFiltro.Name = "btBuscaFiltro";
            this.btBuscaFiltro.Size = new System.Drawing.Size(114, 47);
            this.btBuscaFiltro.TabIndex = 6;
            this.btBuscaFiltro.Text = "Busca";
            this.btBuscaFiltro.UseVisualStyleBackColor = true;
            // 
            // txtBoxFiltroNome
            // 
            this.txtBoxFiltroNome.Location = new System.Drawing.Point(73, 77);
            this.txtBoxFiltroNome.Name = "txtBoxFiltroNome";
            this.txtBoxFiltroNome.Size = new System.Drawing.Size(285, 20);
            this.txtBoxFiltroNome.TabIndex = 5;
            // 
            // txtBoxFiltroRG
            // 
            this.txtBoxFiltroRG.Location = new System.Drawing.Point(73, 50);
            this.txtBoxFiltroRG.Name = "txtBoxFiltroRG";
            this.txtBoxFiltroRG.Size = new System.Drawing.Size(128, 20);
            this.txtBoxFiltroRG.TabIndex = 4;
            // 
            // txtBoxFiltroMatricula
            // 
            this.txtBoxFiltroMatricula.Location = new System.Drawing.Point(102, 19);
            this.txtBoxFiltroMatricula.Name = "txtBoxFiltroMatricula";
            this.txtBoxFiltroMatricula.Size = new System.Drawing.Size(99, 20);
            this.txtBoxFiltroMatricula.TabIndex = 3;
            // 
            // lblFiltroNome
            // 
            this.lblFiltroNome.AutoSize = true;
            this.lblFiltroNome.Location = new System.Drawing.Point(13, 80);
            this.lblFiltroNome.Name = "lblFiltroNome";
            this.lblFiltroNome.Size = new System.Drawing.Size(66, 13);
            this.lblFiltroNome.TabIndex = 2;
            this.lblFiltroNome.Text = "Filtro Nome: ";
            // 
            // lblFiltroRG
            // 
            this.lblFiltroRG.AutoSize = true;
            this.lblFiltroRG.Location = new System.Drawing.Point(13, 53);
            this.lblFiltroRG.Name = "lblFiltroRG";
            this.lblFiltroRG.Size = new System.Drawing.Size(54, 13);
            this.lblFiltroRG.TabIndex = 1;
            this.lblFiltroRG.Text = "Filtro RG: ";
            // 
            // lblFiltroMatricula
            // 
            this.lblFiltroMatricula.AutoSize = true;
            this.lblFiltroMatricula.Location = new System.Drawing.Point(13, 26);
            this.lblFiltroMatricula.Name = "lblFiltroMatricula";
            this.lblFiltroMatricula.Size = new System.Drawing.Size(83, 13);
            this.lblFiltroMatricula.TabIndex = 0;
            this.lblFiltroMatricula.Text = "Filtro Matrícula: ";
            // 
            // lvAtendentes
            // 
            this.lvAtendentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricula,
            this.Nome,
            this.RG,
            this.DataNascimento,
            this.Endereco,
            this.Telefone});
            this.lvAtendentes.FullRowSelect = true;
            this.lvAtendentes.Location = new System.Drawing.Point(14, 137);
            this.lvAtendentes.MultiSelect = false;
            this.lvAtendentes.Name = "lvAtendentes";
            this.lvAtendentes.Size = new System.Drawing.Size(607, 228);
            this.lvAtendentes.TabIndex = 2;
            this.lvAtendentes.UseCompatibleStateImageBehavior = false;
            this.lvAtendentes.View = System.Windows.Forms.View.Details;
            // 
            // Matricula
            // 
            this.Matricula.Text = "Matrícula";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 121;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            this.Endereco.Width = 164;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 73;
            // 
            // DataNascimento
            // 
            this.DataNascimento.Text = "Data de Nascimento";
            this.DataNascimento.Width = 111;
            // 
            // RG
            // 
            this.RG.Text = "RG";
            this.RG.Width = 72;
            // 
            // btListarTodos
            // 
            this.btListarTodos.Location = new System.Drawing.Point(14, 386);
            this.btListarTodos.Name = "btListarTodos";
            this.btListarTodos.Size = new System.Drawing.Size(163, 32);
            this.btListarTodos.TabIndex = 3;
            this.btListarTodos.Text = "Listar Todos";
            this.btListarTodos.UseVisualStyleBackColor = true;
            // 
            // btEditarDados
            // 
            this.btEditarDados.Location = new System.Drawing.Point(210, 386);
            this.btEditarDados.Name = "btEditarDados";
            this.btEditarDados.Size = new System.Drawing.Size(177, 32);
            this.btEditarDados.TabIndex = 4;
            this.btEditarDados.Text = "EditarDados";
            this.btEditarDados.UseVisualStyleBackColor = true;
            // 
            // btExcluirCadastro
            // 
            this.btExcluirCadastro.Location = new System.Drawing.Point(415, 386);
            this.btExcluirCadastro.Name = "btExcluirCadastro";
            this.btExcluirCadastro.Size = new System.Drawing.Size(166, 32);
            this.btExcluirCadastro.TabIndex = 5;
            this.btExcluirCadastro.Text = "Excluir Cadastro";
            this.btExcluirCadastro.UseVisualStyleBackColor = true;
            // 
            // FormGerenciarAtendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 430);
            this.Controls.Add(this.btExcluirCadastro);
            this.Controls.Add(this.btEditarDados);
            this.Controls.Add(this.btListarTodos);
            this.Controls.Add(this.lvAtendentes);
            this.Controls.Add(this.gbFiltrosBusca);
            this.Controls.Add(this.btCadastrarNovo);
            this.Name = "FormGerenciarAtendentes";
            this.Text = "Gerenciar Atendentes";
            this.gbFiltrosBusca.ResumeLayout(false);
            this.gbFiltrosBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarNovo;
        private System.Windows.Forms.GroupBox gbFiltrosBusca;
        private System.Windows.Forms.Button btBuscaFiltro;
        private System.Windows.Forms.TextBox txtBoxFiltroNome;
        private System.Windows.Forms.TextBox txtBoxFiltroRG;
        private System.Windows.Forms.TextBox txtBoxFiltroMatricula;
        private System.Windows.Forms.Label lblFiltroNome;
        private System.Windows.Forms.Label lblFiltroRG;
        private System.Windows.Forms.Label lblFiltroMatricula;
        private System.Windows.Forms.ListView lvAtendentes;
        private System.Windows.Forms.ColumnHeader Matricula;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader RG;
        private System.Windows.Forms.ColumnHeader DataNascimento;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.Button btListarTodos;
        private System.Windows.Forms.Button btEditarDados;
        private System.Windows.Forms.Button btExcluirCadastro;
    }
}