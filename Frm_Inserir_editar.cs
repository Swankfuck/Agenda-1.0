using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Frm_Inserir_editar : Form
    {
        int indice;

        public Frm_Inserir_editar()
        {
            
            InitializeComponent();
            
            ConstroiLista();

        }

        private void btn_fechar_voltar_Click(object sender, EventArgs e)
        {
            //passo 4
            //fechar quadro
            this.Close();// para fechar apenas esse quadro e voltar para menu iniciar
        }

        private void ConstroiLista()
        {
            //adiciona a lista de contatos os contatos registrados
            lista_contatos.Items.Clear();
            
            foreach (cl_contato contato in cl_geral.LIST_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }

            //atualizar o numero de registros
            label_registros.Text = "Registros: " + lista_contatos.Items.Count;

            //impedir edição e eliminação do registro sem clicar no contato
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //insere um novo registro na lista

            //verifica se todos os campos estão preenchidos
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos");
                return;
            }

            //verifica se existe contato igual na lsita
            foreach (cl_contato contato in cl_geral.LIST_CONTATOS)
            {
                if(contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! Esse registro já existe.");
                    return;
                }
            }




            //salvar novo registro
            cl_geral.Salvar_novo_registro(text_nome.Text, text_numero.Text);

            //atualizar a lista de contatos
            ConstroiLista();

            //depois que salvar um contato ao invez dele ficar aparecendo nas caixa ele apaga !!
            text_nome.Text = "";
            text_numero.Text = "";
            text_numero.Focus(); // focus para o cursor voltar ao "nome"

        }

        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato para ativar os botões editar e apagar

            //verificar se indice é igual a -1
            if (lista_contatos.SelectedIndex == -1) return;

            //seleciona um indice da lista
            indice = lista_contatos.SelectedIndex;
            btn_editar.Enabled = true;
            btn_apagar.Enabled = true;


        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //se selecionar apagar, apaga o registro selecionado

            //1 apagar o registro da lista
            cl_geral.LIST_CONTATOS.RemoveAt(indice);

            //2 renovar o ficheiro
            cl_geral.Salvar_ficheiro();

            //3 reconstruir a lista
            ConstroiLista();

        }
    }
}
