using AgendaDeContatos;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        ListaContatos listaContatos = new ListaContatos();
        bool executando = true;
        
        while(executando)
        {
            Console.WriteLine("--------Lista de Contatos--------\n");
            Console.WriteLine("1. Adicionar");
            Console.WriteLine("2. Exibir Contatos");
            Console.WriteLine("3. Remover Contato");
            Console.WriteLine("4. Sair\n");
            Console.WriteLine("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Sobrenome: ");
                    string sobrenome = Console.ReadLine();
                    Console.WriteLine("Número: ");
                    string numero = Console.ReadLine();
                    Console.WriteLine("País: ");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cidade: ");
                    string cidade = Console.ReadLine();
                    Console.WriteLine("Marcador: ");
                    string marcador = Console.ReadLine();
                    listaContatos.adicionarContato(nome, sobrenome, numero, pais, cidade, marcador);
                    break;
                case "2":
                    listaContatos.exibirContatos();
                    break;
                case "3":
                    Console.WriteLine("Nome do contato para remover: ");
                    string contatoRemover = Console.ReadLine();
                    listaContatos.removerContato(contatoRemover);
                    break;
                case "4":
                    executando = false;
                    Console.WriteLine("Saindo da Lista de Contatos.");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida.");
                    break;
            }
        }
    }
}