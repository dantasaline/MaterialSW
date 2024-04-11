namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula a área Quadrado/Retângulo");

            Area area= new Area();

            Console.WriteLine(area.Calcular());
            Console.WriteLine(area.Dados());
        }
    }
}