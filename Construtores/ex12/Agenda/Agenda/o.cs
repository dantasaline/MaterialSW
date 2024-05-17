using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }

    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa novaPessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(novaPessoa);
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoaParaRemover = BuscaPessoa(nome);
            if (pessoaParaRemover != null)
            {
                pessoas.Remove(pessoaParaRemover);
                Console.WriteLine($"Pessoa '{nome}' removida da agenda.");
            }
            else
            {
                Console.WriteLine($"Pessoa '{nome}' não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(pessoa => pessoa.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}
