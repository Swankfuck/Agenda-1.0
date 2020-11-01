using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Agenda
{

    public static class cl_geral // lembrando que toda classe statci tem que por static antes
    {
        //passo 1
        //criação do texto para mostrar a versão
        public static string versao = "v.1.0.0";

        //passo 5/6
        //lista de contato
        //public static list<cl_contato> LISTA_CONTATO;
        public static List<cl_contato> LIST_CONTATOS;
        

        public static void ConstroiListaContato()
        {
            //metodo de carregamento da lista de contato
            //verificar se o ficheiro existe

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";
            
            //cria a lista vazia
            LIST_CONTATOS = new List<cl_contato>();

            if (File.Exists(nome_ficheiro))

            {
              StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                                
                while (!ficheiro.EndOfStream) // enquanto não for verdadeiro a chegada do fim do ficheiro
                {
                    //carrega nome
                    string nome = ficheiro.ReadLine();

                    //carrega numero
                    string numero = ficheiro.ReadLine();

                    //adiciona a lista de contato
                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    LIST_CONTATOS.Add(novo_contato);

                }
                              
                
                ficheiro.Dispose();

            }



            

        }

        public static void Salvar_novo_registro(string nome, string numero)
        {
            //gravar um novo registro(na lista e no ficheiro)


            //poderia fazer assim tambem
            //public static void Salvar_novo_registro(string nome, string numero)
            //cl_contato novo = new cl_contato();
            //novo.nome = nome;
            //novo.numero = numero;
            //LIST_CONTATOS.Add(novo);

            //ou posso fazer dessa maneira abaixo\/

            //salvar na lista (codigo de forma reduzida)
            LIST_CONTATOS.Add(new cl_contato() { nome = nome, numero = numero });

            //salva ficheiro
            Salvar_ficheiro();
                                  
        }
        public static void Salvar_ficheiro() // salvar no ficheiro
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";
            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            foreach (cl_contato contato in LIST_CONTATOS)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.numero);
            }
            ficheiro.Dispose();
        }
    }

    
}
