using static System.Net.Mime.MediaTypeNames;

namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da pessoa");
            Pessoa a = new Pessoa();
            Console.WriteLine(a.Info());
            Console.WriteLine(a.CalcIdade());
        }
    }
}