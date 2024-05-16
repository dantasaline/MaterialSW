namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            // Exibindo informações do produto
            produto1.Exibir();

            // Adicionando itens ao estoque
            produto1.Adicionar(500);
            produto1.Exibir();

            // Removendo itens do estoque
            produto1.Remover(430);
            produto1.Exibir();

            Console.ReadLine();
        }
    }
    
}