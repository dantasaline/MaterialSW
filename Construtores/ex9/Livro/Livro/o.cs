using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    public class Livro
    {
        private string titulo;
        private string autor;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro não pode ser vazio.");
                }
                titulo = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O autor do livro não pode ser vazio.");
                }
                autor = value;
            }
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
