namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //INSTÂNCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //ACESSANDO UM ATRIBUTO  PUBLICO DO OBJRTO  
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Rosa";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "Verde";

            //VISUALIZANDO OS VALORES DE ATRIBUTOS
            Console.WriteLine("Essa é a lâmpada 1");
            Console.WriteLine("A lâmpada está ligada? " + lampada1.Ligada);
            Console.WriteLine("A cor da lâmpada é? " + lampada1.Cor);
            Console.WriteLine("A potência da lâmpada é ? " + lampada1.Potencia);
            Console.WriteLine("************************************************");
            Console.WriteLine("Essa é a lâmpada 2");
            Console.WriteLine("A lâmpada está ligada? " + lampada2.Ligada);
            Console.WriteLine("A cor da lâmpada é? " + lampada2.Cor);
            Console.WriteLine("A potência da lâmpada é ? " + lampada2.Potencia);

        }
    }
}