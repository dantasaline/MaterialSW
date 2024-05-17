namespace Imoveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();
            int opcao;
            // Laço do-while para exibir o menu até que o usuário escolha sair (opção 0)
            do
            {
                // Exibe o menu de opções
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Apresentar Todos os Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                // Lê a opção escolhida pelo usuário e converte para inteiro
                opcao = int.Parse(Console.ReadLine());

                // Executa a ação correspondente à opção escolhida pelo usuário
                switch (opcao)
                {
                    case 1:
                        InserirImovel(corretora);
                        break;
                    case 2:
                        AlterarPrecoImovel(corretora);
                        break;
                    case 3:
                        ApresentarImoveis(corretora);
                        break;
                    case 4:
                        CalcularValorMedioImoveis(corretora);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        static void InserirImovel(CorretoraDeImoveis corretora)
        {
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();

            corretora.AdicionarImovel(endereco, preco, tipo);
            Console.WriteLine("Imóvel adicionado com sucesso!");
        }

        static void AlterarPrecoImovel(CorretoraDeImoveis corretora)
        {
            Console.Write("Endereço do imóvel para alterar o preço: ");
            string endereco = Console.ReadLine();
            Console.Write("Novo preço: ");
            decimal novoPreco = decimal.Parse(Console.ReadLine());

            bool sucesso = corretora.AlterarPreco(endereco, novoPreco);
            if (sucesso)
            {
                Console.WriteLine("Preço alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado!");
            }
        }

        static void ApresentarImoveis(CorretoraDeImoveis corretora)
        {
            var imoveis = corretora.ListarImoveis();
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel cadastrado.");
            }
            else
            {
                foreach (var imovel in imoveis)
                {
                    Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: R${imovel.Preco:F2}, Tipo: {imovel.Tipo}");
                }
            }
        }

        static void CalcularValorMedioImoveis(CorretoraDeImoveis corretora)
        {
            decimal valorMedio = corretora.CalcularValorMedio();
            Console.WriteLine($"Valor médio dos imóveis: R${valorMedio:F2}");
        }
    }
    
}
