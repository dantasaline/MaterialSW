using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double AreaTotal { get; set;}

        public string Calcular()
        {
            Console.WriteLine("Digite a base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            AreaTotal = Base * Altura;
            string tipo = "";

            if (Base == Altura)
            {
                tipo = "Quadrado";
            }
            else
            {
                tipo = "Retângulo";
            }

            string resultado = "A área é: "+ AreaTotal+ " e isso é um ";
            resultado += tipo;
            return resultado;
        }

        public string Dados()
        {
            string informacao = "O valor da base é "+ Base;
            informacao += "\nO valor da altura é "+Altura;
            return informacao;
        }
    }
}
