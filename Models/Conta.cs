using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }
    }
}