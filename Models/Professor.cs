using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoOO.Models
{
    public class Professor : Pessoa
    {
       
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }

//polimorfismo
// o método com sealed (selada) não pode ser utilizado em outra classe
        public sealed override void Apresentar()
        {
           Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} nos e sou um professor e ganho {Salario}");
        }
    }
}