using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class Conta
    {
        public string? num_conta { get; set; }

        private float saldo = 1200;

        private float limite = 500;


        public void olha_saldo()
        {

            Console.WriteLine("seu saldo é de: R$" + saldo);

        }

        public void deposito(float deposit)
        {

            saldo += deposit;
            Console.WriteLine("Seu saldo agora é de: R$" + saldo);
            Console.WriteLine("Você pode sacar até R$" + (saldo + limite));

        }

        public void saque(float saque)
        {

            if (saque <= saldo + limite)
            {

                saldo -= saque;
                Console.WriteLine("Seu saldo após o saque é de: R$" + saldo);

            }

            else 
            {

                Console.WriteLine("Saque não disponivel, valor solicitado está além do limite");

            }

        }

    } 

}
        

        

