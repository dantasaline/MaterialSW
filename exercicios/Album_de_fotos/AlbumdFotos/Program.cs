namespace AlbumdFotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando numero de paginas:");
            Album album = new Album();

            Console.WriteLine(album.Pagina());
        }
    }
}