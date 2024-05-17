﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public string Som {  get; set; }
        public int Idade { get; set; }

        

        public Animal(string nome, string especie, int idade, string som)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Som = som;
        }

        public void EmitirSom()
        {
            
            Console.WriteLine($"{Nome} faz {Som}.");
        }
    }
}
