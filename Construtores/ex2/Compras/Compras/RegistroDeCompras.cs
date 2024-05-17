using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    internal class RegistroDeCompras
    {
        public class Compra
        {
            public DateTime Data { get; set; }
            public string Produto { get; set; }
            public decimal Valor { get; set; }
        }

        // Lista para armazenar as compras
        private List<Compra> compras;

        // Construtor
        public RegistroDeCompras()
        {
            compras = new List<Compra>();
            // Itens iniciais
            Adicionar(new DateTime(2023, 5, 17), "Livro", 29.90m);
            Adicionar(new DateTime(2023, 5, 18), "Caneta", 3.50m);
        }

        // Adicionar uma compra à lista
        public void Adicionar(DateTime data, string produto, decimal valor)
        {
            Compra compra = new Compra
            {
                Data = data,
                Produto = produto,
                Valor = valor
            };
            // Adiciona a nova compra à lista de compras
            compras.Add(compra);
        }

        // Mostrar todas as compras
        public List<Compra> ListarCompras()
        {
            return compras;
        }
    }
}
