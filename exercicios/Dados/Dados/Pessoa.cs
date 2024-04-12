using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dados
{
    internal class Pessoa
    {
        private string? Nome { get; set; }
        private DateTime Nascimento { get; set; }
        private Double Altura { get; set; }
        private int Idade {  get; set; }
        public string Info()
        {
            Nome = "Aline";
            Nascimento =  new DateTime(2007, 7, 26);
            Altura = Convert.ToDouble(1.73);

            return $"Nome: {Nome}\nNascimento: {Nascimento}\nAltura: {Altura}";
        }

        public string CalcIdade()
        {
            int Ano = 2024;
            Idade = Ano - Nascimento.Year;

            return $"Idade: {Idade}";
        }

    }
}
