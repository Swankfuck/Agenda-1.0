using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{        
    public partial class Frm_texto_pesquisa : Form
    {
        //propriedade de controle
        public bool cancelado { get; set; }//criado para fazer o cancelar pesquisa
        public string pesquisa { get; set; }//criado para pesquisar
        public Frm_texto_pesquisa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //cancela o quadro
            cancelado = true;
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //define texto e fecha o quadro
            if (text_texo.Text == "") return; // caso não ter o nome ou numero e ao apertar o enter ele vai aprecer a lista em branco
            pesquisa = text_texo.Text;
            cancelado = false;
            this.Close();
        }

        private void text_texo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btn_pesquisar_Click(btn_pesquisar, EventArgs.Empty);
        }
    }
}
