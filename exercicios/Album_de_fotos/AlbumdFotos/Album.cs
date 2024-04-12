using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumdFotos
{
    internal class Album
    {
        public double Nfotos { get; set; }
        public double Pag { get; set; }
        public double resto { get; set; }

        public string Pagina()
        {

            Console.WriteLine("Quantas fotos você vai usar?");
            Nfotos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantas fotos por página?");
            Pag = Convert.ToDouble(Console.ReadLine());

            resto = Nfotos % Pag;

            if (resto == 1)
            {
                return "Você pode colocar " + Nfotos / Pag + " e vai sobrar " + resto + " fotos";
            }
            else
            {
                return "Você pode colocar " + Nfotos / Pag + " fotos por página";
            }
        }
    }
}
