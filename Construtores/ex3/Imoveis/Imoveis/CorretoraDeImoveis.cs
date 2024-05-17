using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imoveis
{
    internal class CorretoraDeImoveis
    {
        public class Imovel
        {
            public string Endereco { get; set; }
            public decimal Preco { get; set; }
            public string Tipo { get; set; }
        }

        // Lista para armazenar os imóveis
        private List<Imovel> imoveis;

        // Construtor
        public CorretoraDeImoveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para adicionar um imóvel
        public void AdicionarImovel(string endereco, decimal preco, string tipo)
        {
            Imovel imovel = new Imovel
            {
                Endereco = endereco,
                Preco = preco,
                Tipo = tipo
            };
            imoveis.Add(imovel);
        }

        // Método para listar todos os imóveis
        public List<Imovel> ListarImoveis()
        {
            return imoveis;
        }

        // Método para alterar o preço de um imóvel
        public bool AlterarPreco(string endereco, decimal novoPreco)
        {
            foreach (var imovel in imoveis)
            {
                if (imovel.Endereco == endereco)
                {
                    imovel.Preco = novoPreco;
                    return true; // Preço alterado com sucesso
                }
            }
            return false; // Imóvel não encontrado
        }

        // Método para calcular o valor médio dos imóveis
        public decimal CalcularValorMedio()
        {
            if (imoveis.Count == 0)
                return 0;

            return imoveis.Average(imovel => imovel.Preco);
        }
    }
}
