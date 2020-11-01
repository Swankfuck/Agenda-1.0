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
    public partial class fmr_resultado_pesquisa : Form
    {
        string texto;
        public fmr_resultado_pesquisa(string texto)
        {
            InitializeComponent();
            //definir o texto de pesquisa
            this.texto = texto.ToUpper(); //coloquei text.toupper para que na hora de pesquisar mesmo independente do nome estar em maiuscula ou minuscula ele mostre o nome !
            //resumindo o toupper vai deixar todos contatos maisculos aqui no backend mais sem mostrar no front end
            //para assim mesmo se o usuario colocar maiuscula ou minuscula ele encontre o contato
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro
            this.Close();
        }

        private void fmr_resultado_pesquisa_Load(object sender, EventArgs e)
        {
            //executa a pesquisa e constroi a lista
            ExecutarPesquisa();//primeiro coloquei o nome do metodo(ele nao estava criado) depois coloquei o mouse em cima e apareceu a lampada e cliquei 2x nela e logo abaixo ela criou automaticamente o metodo para min
        }

        private void ExecutarPesquisa()
        {
            //realiza a pesquisa e apresenta os dados
            List<cl_contato> lista_final = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LIST_CONTATOS) //lembrando que a maneiras mais atualizadas e facil de realizar a pesquisa
            {
                if(contato.nome.ToUpper().Contains(texto) || contato.numero.ToUpper().Contains(texto)) // se o nome ou o numero contem o texto ele vai adicionar o contato a lista de resultado finais
                {
                    lista_final.Add(contato);
                }
            }


            //apresentar os resultados na lista
            list_resultado.Items.Clear();
            foreach (cl_contato contato in lista_final)
            {
                list_resultado.Items.Add(contato.nome + " (" + contato.numero + ")");

            }
            label_registros.Text = "Registros: " + list_resultado.Items.Count; // apresenta o numero de registros encontrados
               
            

        }

        private void btn_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            Frm_texto_pesquisa f = new Frm_texto_pesquisa();
            f.ShowDialog();

            //quando o quadro é fehcado...
            if (f.cancelado) return;

            texto = f.pesquisa.ToUpper();
            ExecutarPesquisa();

        }

        private void list_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
