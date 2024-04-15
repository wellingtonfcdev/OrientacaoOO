using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

//polimorfismo
        public override void Apresentar()
        {
           Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} nos e sou um professor e ganho {Salario}");
        }
    }
}