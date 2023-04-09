using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv13Conta
{
    internal class Movimentacao
    {
        public double valor;
        public string tipo;

        public Movimentacao(double valor, string tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public string GetTipo()
        {
            return this.tipo;
        }


        
    }
}
