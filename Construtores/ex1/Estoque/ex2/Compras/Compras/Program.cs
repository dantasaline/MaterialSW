namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroDeCompras registro = new RegistroDeCompras();

            // Mostra a lista inicial de compras
            Console.WriteLine("Lista inicial de compras:");
            MostrarCompras(registro.ListarCompras());

            // Adiciona mais algumas compras
            registro.Adicionar(new DateTime(2025, 6, 1), "Caderno", 15.00m);
            registro.Adicionar(new DateTime(2025, 6, 2), "Lápis", 1.20m);

            // Mostra a lista de compras após adicionar mais itens
            Console.WriteLine("\nLista de compras após adicionar novos itens:");
            MostrarCompras(registro.ListarCompras());
        }

        // Método auxiliar para mostrar as compras
        public static void MostrarCompras(List<RegistroDeCompras.Compra> compras)
        {
            foreach (var compra in compras)
            //foreach é um laço de repetição que percorre todos os itens de uma lista
            {
                Console.WriteLine($"Data: {compra.Data:d}, Produto: {compra.Produto}, Valor: R${compra.Valor:F2}");
            }
        }
           
    }
}
