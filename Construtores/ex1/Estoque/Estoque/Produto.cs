using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private int quantEstoque;

        public Produto()
        {
            nome = "Camiseta";
            preco = 25.75;
            quantEstoque = 900;
        }

        //adicionar itens ao estoque
        public void Adicionar(int quantidade)
        {
            if (quantidade > 0)
                quantEstoque += quantidade;
            else
                Console.WriteLine("Quantidade inválida. Não é possível adicionar itens.");
        }

        //remover itens do estoque
        public void Remover(int quantidade)
        {
            if (quantidade > 0 && quantidade <= quantEstoque)
                quantEstoque -= quantidade;
            else
                Console.WriteLine("Quantidade inválida. Não é possível remover itens.");
        }

        // exibir informações do produto
        public void Exibir()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço por peça: R${preco}");  
            Console.WriteLine($"Quantidade em Estoque: {quantEstoque}");
        }
    }

}
