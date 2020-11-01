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
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
            //carrega os contato
            cl_geral.ConstroiListaContato();

            //passo 1 
            //apresenta versao do programa feito na clase static
            label_versao.Text = cl_geral.versao;
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //passo 2
            // sair da aplicação ?
            //pergunta se pretende mesmo sair da aplicão
            if (MessageBox.Show("Deseja sair do programa ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            //sair da aplicação definitivamente
            Application.Exit();
        }

        private void btn_inserir_editar_Click(object sender, EventArgs e)
        {
            //passo 3
            //abre um quadro para salvar os contatos
            Frm_Inserir_editar editar = new Frm_Inserir_editar();
            editar.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir o quadro de pesquisa
            Frm_texto_pesquisa f = new Frm_texto_pesquisa();
            f.ShowDialog();


            //quando fecha o quadro, verifica se foi cancelado
            if (f.cancelado) return;

            //abrir o quadro de com resultado da pesquisa
            fmr_resultado_pesquisa ff = new fmr_resultado_pesquisa(f.pesquisa); //pesquisa estra criado no frm_text_pesquisa
            ff.ShowDialog();

        }
    }
}
