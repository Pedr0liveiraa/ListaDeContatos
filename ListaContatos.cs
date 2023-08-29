using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos
{
    public class ListaContatos
    {
        private List<Contato> listaContatos = new List<Contato>();
        public ListaContatos() 
        { 
            this.listaContatos = new List<Contato>();
        }

        public void adicionarContato(string nome, string sobrenome, string numero, string pais, string cidade, string marcador)
        {
            listaContatos.Add(new Contato(nome, sobrenome, numero, pais, cidade, marcador));
        }

        public void removerContato(String nomeContato)
        {
            Contato contatoParaRemover = null;
            foreach(Contato contato in listaContatos)
            {
                if(contato.Name == nomeContato)
                {
                    contatoParaRemover = contato;
                    break;
                }
            }
            listaContatos.Remove(contatoParaRemover);
        }

        public void exibirContatos()
        {
            Console.WriteLine($"Você possui {listaContatos.Count} contatos na sua lista de contatos\n");
            foreach(Contato contato in listaContatos)
            {
                Console.WriteLine($"{contato.Name} {contato.LastName}, {contato.Number}, {contato.Country}, {contato.City}, {contato.Marker}\n");
            }
        }
    }
}
