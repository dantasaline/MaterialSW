using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class AgenciaTelefonica
    {
        private List<Contato> contatos;

        public AgenciaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato()
        {
            Console.WriteLine("Digite o nome do contato:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone do contato:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do contato:");
            string email = Console.ReadLine();

            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso.");
        }

        public void RemoverContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja remover:");
            string nome = Console.ReadLine();

            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);//procura na lista contatos o primeiro contato cujo nome corresponda ao nome especificado.
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        public void BuscarContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja buscar:");
            string nome = Console.ReadLine();

            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);//procura na lista contatos o primeiro contato cujo nome corresponda ao nome especificado.
            if (contato != null)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, E-mail: {contato.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }

    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}

