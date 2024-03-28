namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.deposito(200);

            conta.olha_saldo();

            conta.saque(2500);

            conta.olha_saldo();
        }
    }
}