using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    public class Playlist
    {
        private List<Musica> listaDeMusicas;
        private string donoDaPlaylist;
        private Random random;

        public Playlist(string dono)
        {
            listaDeMusicas = new List<Musica>();
            donoDaPlaylist = dono;
            random = new Random();
        }

        public void AdicionarMusica(string nome, string autor, string gravadora)
        {
            Musica novaMusica = new Musica(nome, autor, gravadora);
            listaDeMusicas.Add(novaMusica);
        }

        public void TocarMusicaAleatoria()
        {
            if (listaDeMusicas.Count == 0)
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas para reproduzir.");
                return;
            }

            int indiceAleatorio = random.Next(0, listaDeMusicas.Count);
            Musica musicaTocada = listaDeMusicas[indiceAleatorio];
            Console.WriteLine($"Tocando música: {musicaTocada.Nome}");
        }
    }

   
        }
