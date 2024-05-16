namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            // Exibindo informações do produto
            produto.Exibir();

            // Adicionando itens ao estoque
            produto.Adicionar(500);
            produto.Exibir();

            // Removendo itens do estoque
            produto.Remover(430);
            produto.Exibir();

            Console.ReadLine();
        }
    }
    
}
