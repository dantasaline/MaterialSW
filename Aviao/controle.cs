using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    internal class Controle
    {
        public string? Compania { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Altura { get; set; }


        public void Cima(int pes)
        {

            Altura += pes;

        }

        public void Baixo(int pes)
        {
            if (pes >= 0)
            {
                Altura -= pes;
            }
        
            else
            {
                Altura = 0;
            }
        }

        public void Acelerar(int kmh)
        {
            Velocidade += kmh;

        }

        public void Desacelerar(int kmh)
        {
            if (kmh >= 0)
            {
                Velocidade -= kmh;
            }

            else
            {
                Velocidade = 0;
            }

        }

    }
}
