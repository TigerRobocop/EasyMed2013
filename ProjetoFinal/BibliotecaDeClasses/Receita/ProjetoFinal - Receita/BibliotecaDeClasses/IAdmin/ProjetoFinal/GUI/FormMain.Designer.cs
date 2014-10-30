namespace IAdmin.GUI
{
    partial class FormMain
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
            this.btFormGerenciarAtendentes = new System.Windows.Forms.Button();
            this.btFormGerenciarMedicos = new System.Windows.Forms.Button();
            this.btFormEstoquista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFormGerenciarAtendentes
            // 
            this.btFormGerenciarAtendentes.Location = new System.Drawing.Point(28, 23);
            this.btFormGerenciarAtendentes.Name = "btFormGerenciarAtendentes";
            this.btFormGerenciarAtendentes.Size = new System.Drawing.Size(205, 46);
            this.btFormGerenciarAtendentes.TabIndex = 0;
            this.btFormGerenciarAtendentes.Text = "Gerenciar Atendentes";
            this.btFormGerenciarAtendentes.UseVisualStyleBackColor = true;
            this.btFormGerenciarAtendentes.Click += new System.EventHandler(this.btFormGerenciarAtendentes_Click);
            // 
            // btFormGerenciarMedicos
            // 
            this.btFormGerenciarMedicos.Location = new System.Drawing.Point(28, 88);
            this.btFormGerenciarMedicos.Name = "btFormGerenciarMedicos";
            this.btFormGerenciarMedicos.Size = new System.Drawing.Size(205, 48);
            this.btFormGerenciarMedicos.TabIndex = 1;
            this.btFormGerenciarMedicos.Text = "Gerenciar Médicos";
            this.btFormGerenciarMedicos.UseVisualStyleBackColor = true;
            this.btFormGerenciarMedicos.Click += new System.EventHandler(this.btFormGerenciarMedicos_Click);
            // 
            // btFormEstoquista
            // 
            this.btFormEstoquista.Location = new System.Drawing.Point(26, 158);
            this.btFormEstoquista.Name = "btFormEstoquista";
            this.btFormEstoquista.Size = new System.Drawing.Size(207, 45);
            this.btFormEstoquista.TabIndex = 2;
            this.btFormEstoquista.Text = "Gerenciar Estoquista";
            this.btFormEstoquista.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 257);
            this.Controls.Add(this.btFormEstoquista);
            this.Controls.Add(this.btFormGerenciarMedicos);
            this.Controls.Add(this.btFormGerenciarAtendentes);
            this.Name = "FormMain";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormGerenciarAtendentes;
        private System.Windows.Forms.Button btFormGerenciarMedicos;
        private System.Windows.Forms.Button btFormEstoquista;
    }
}