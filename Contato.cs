using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos
{
    public class Contato
    {
        private String Nome;
        private String Sobrenome;
        private String Numero;
        private String Pais;
        private String Cidade;
        private String Marcador;

        public Contato(string nome, string sobrenome, string numero, string pais, string cidade, string marcador)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Numero = numero;
            Pais = pais;
            Cidade = cidade;
            Marcador = marcador;
        }

        public string Name
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string LastName
        {
            get { return Sobrenome; }
            set { Sobrenome = value; }
        }

        public string Number
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public string Country
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string City
        {
            get { return Cidade; }
            set { Cidade = value; }
        }

        public string Marker
        {
            get { return Marcador; }
            set { Marcador = value; }
        }
    }
}
