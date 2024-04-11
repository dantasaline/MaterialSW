using static System.Net.Mime.MediaTypeNames;

namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da pessoa");
            Pessoa a = new Pessoa();
            a.Info();
        }
    }
}