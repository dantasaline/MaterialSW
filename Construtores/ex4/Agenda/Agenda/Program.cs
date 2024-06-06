namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgenciaTelefonica agenda = new AgenciaTelefonica();
            bool continuar = true;

            while //continuar se for verdadeiro
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Remover Contato");
                Console.WriteLine("3. Buscar Contato");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        agenda.AdicionarContato();
                        break;
                    case "2":
                        agenda.RemoverContato();
                        break;
                    case "3":
                        agenda.BuscarContato();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
