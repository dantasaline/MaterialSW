namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do dono da playlist:");
            string nomeDono = Console.ReadLine();

            Playlist playlist = new Playlist(nomeDono);

            while (true)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1. Adicionar Música");
                Console.WriteLine("2. Tocar Música Aleatória");
                Console.WriteLine("3. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome da música:");
                        string nomeMusica = Console.ReadLine();
                        Console.WriteLine("Digite o nome do autor:");
                        string autorMusica = Console.ReadLine();
                        Console.WriteLine("Digite o nome da gravadora:");
                        string gravadoraMusica = Console.ReadLine();
                        playlist.AdicionarMusica(nomeMusica, autorMusica, gravadoraMusica);
                        Console.WriteLine($"Música '{nomeMusica}' adicionada à playlist.");
                        break;
                    case "2":
                        playlist.TocarMusicaAleatoria();
                        break;
                    case "3":
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
