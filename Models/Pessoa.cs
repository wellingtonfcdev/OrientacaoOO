using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoOO.Models
{
    
    public class Pessoa
    {
        public Pessoa(string nome)
    {
       Nome = nome;
    }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string  Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"O nome é {Nome} e tem {Idade} anos de idade!");
        }
    }
}