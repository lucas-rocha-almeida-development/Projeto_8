using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_8
{
    internal class BaseDeDados
    {//atributo

        private List<CadastroPessoa> listaDePessoas;

        //metodos
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);

        }
        public List<CadastroPessoa> PesquisaPessoaDoc(string pDocumentoPessoa)
        {
            List<CadastroPessoa> listaTemporaria = listaDePessoas.Where(x=> x.NumeroDoDocumento == pDocumentoPessoa).ToList();
            if (listaTemporaria.Count() > 0)
            {
                return listaTemporaria;

            }
            else
                return null;
            

        }
        public List<CadastroPessoa> RemoverPessoaPorDoc (string pDocumentoPessoa)
        {
            List <CadastroPessoa> listaTemporaria = listaDePessoas.Where(x => x.NumeroDoDocumento == pDocumentoPessoa).ToList();

            if (listaTemporaria.Count() > 0)
            {
                foreach (var objetopessoa in listaTemporaria)
                {
                    listaDePessoas.Remove(objetopessoa);
                }

                return listaTemporaria;

            }
            else
                return null;



        }

        //construtor

        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }

    }
}
