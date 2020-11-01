namespace Agenda
{
    partial class Frm_Inserir_editar
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
            this.btn_fechar_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_registros = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar_voltar
            // 
            this.btn_fechar_voltar.Location = new System.Drawing.Point(429, 358);
            this.btn_fechar_voltar.Name = "btn_fechar_voltar";
            this.btn_fechar_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar_voltar.TabIndex = 3;
            this.btn_fechar_voltar.Text = "Fechar";
            this.btn_fechar_voltar.UseVisualStyleBackColor = true;
            this.btn_fechar_voltar.Click += new System.EventHandler(this.btn_fechar_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(68, 31);
            this.text_nome.MaxLength = 75;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(283, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(68, 57);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(131, 20);
            this.text_numero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero:";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(68, 83);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 2;
            this.btn_gravar.Text = "Salvar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(12, 154);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(492, 186);
            this.lista_contatos.TabIndex = 9;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de contatos registrados:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Location = new System.Drawing.Point(12, 343);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(66, 13);
            this.label_registros.TabIndex = 10;
            this.label_registros.Text = "Registros : 0";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(348, 358);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 4;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(267, 358);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // Frm_Inserir_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 393);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inserir_editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
    }
}