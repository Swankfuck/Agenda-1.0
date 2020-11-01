namespace Agenda
{
    partial class fmr_resultado_pesquisa
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
            this.btn_nova_pesquisa = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.list_resultado = new System.Windows.Forms.ListBox();
            this.label_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nova_pesquisa
            // 
            this.btn_nova_pesquisa.Location = new System.Drawing.Point(121, 140);
            this.btn_nova_pesquisa.Name = "btn_nova_pesquisa";
            this.btn_nova_pesquisa.Size = new System.Drawing.Size(98, 32);
            this.btn_nova_pesquisa.TabIndex = 0;
            this.btn_nova_pesquisa.Text = "Nova Pesquisa";
            this.btn_nova_pesquisa.UseVisualStyleBackColor = true;
            this.btn_nova_pesquisa.Click += new System.EventHandler(this.btn_nova_pesquisa_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(223, 140);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(98, 32);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // list_resultado
            // 
            this.list_resultado.FormattingEnabled = true;
            this.list_resultado.Location = new System.Drawing.Point(4, 0);
            this.list_resultado.Name = "list_resultado";
            this.list_resultado.Size = new System.Drawing.Size(318, 134);
            this.list_resultado.TabIndex = 2;
            this.list_resultado.SelectedIndexChanged += new System.EventHandler(this.list_resultado_SelectedIndexChanged);
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Location = new System.Drawing.Point(0, 140);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(66, 13);
            this.label_registros.TabIndex = 11;
            this.label_registros.Text = "Registros : 0";
            // 
            // fmr_resultado_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 180);
            this.ControlBox = false;
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.list_resultado);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_nova_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmr_resultado_pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " RESULTADO DA PESQUISA";
            this.Load += new System.EventHandler(this.fmr_resultado_pesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nova_pesquisa;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ListBox list_resultado;
        private System.Windows.Forms.Label label_registros;
    }
}