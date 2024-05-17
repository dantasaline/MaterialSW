namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Animal("Sirius", "Cachorro", 5, "AUAU");
            cachorro.EmitirSom();

            Animal gato = new Animal("Jasper", "Gato", 3,"MIAU" );
            gato.EmitirSom();

            Animal papagaio = new Animal("Loro", "Papagaio", 7, "Loro quer biscoito");
            papagaio.EmitirSom();
        }
    }
}
