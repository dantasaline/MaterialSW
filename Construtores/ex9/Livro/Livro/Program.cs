namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();

            while (true)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o título do livro:");
                        string tituloLivro = Console.ReadLine();
                        Console.WriteLine("Digite o autor do livro:");
                        string autorLivro = Console.ReadLine();
                        Livro novoLivro = new Livro(tituloLivro, autorLivro);
                        livros.Add(novoLivro);
                        Console.WriteLine("Livro adicionado com sucesso.");
                        break;
                    case "2":
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
