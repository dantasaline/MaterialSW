namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome da pessoa:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade da pessoa:");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a altura da pessoa:");
                        float altura = Convert.ToSingle(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        Console.WriteLine("Pessoa armazenada com sucesso.");
                        break;
                    case "2":
                        Console.WriteLine("Digite o nome da pessoa a ser removida:");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome da pessoa a ser buscada:");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine($"Pessoa encontrada: Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                        }
                        else
                        {
                            Console.WriteLine($"Pessoa '{nomeBuscar}' não encontrada na agenda.");
                        }
                        break;
                    case "4":
                        agenda.ImprimeAgenda();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
