using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Pessoa
    {
        private string? Nome { get; set; }
        private DateTime Nascimento { get; set; }
        private Double Altura { get; set; }
        public string Info()
        {
            Nome = "Aline";
            Nascimento =  new DateTime(2007, 7, 26);
            Altura = Convert.ToDouble(1.73);

            return Info();
        }


    }
}
