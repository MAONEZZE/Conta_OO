using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Atv13Conta
{
    internal class ContaCorrente
    {
        public double saldo;
        public int numero;
        public int limite;
        public bool especial;
        public Movimentacao[] movimentacao;

        public ContaCorrente(double saldo, int numero, int limite, bool especial, Movimentacao[] movimentacao)
        {
            this.saldo = saldo;
            this.numero = numero;
            this.limite = limite;
            this.especial = especial;
            this.movimentacao = movimentacao;
        }

        public bool VerificadorDeValor(double valor)
        {
            if(valor > (this.saldo + this.limite) || valor < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Sacar(double valor)
        {
            if(VerificadorDeValor(valor))
            {
                this.saldo = this.saldo - valor;
            }
            else
            {
                Console.WriteLine("Não foi possivel sacar o valor desejado");
            }
        }

        public void Depositar(double valor)
        {
            if (VerificadorDeValor(valor))
            {
                this.saldo = this.saldo + valor;
            }
            else
            {
                Console.WriteLine("Não foi possivel sacar o valor desejado");
            }
        }

        public void TransferirPara(ContaCorrente contaX, double valor)
        {
            contaX.saldo += valor;
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Saldo: "+this.saldo);
            Console.WriteLine("Número da Conta: "+this.numero);
            Console.WriteLine("Limite da Conta: "+this.limite);
            Console.WriteLine("É especial: "+this.especial);
            Console.WriteLine();
            Console.WriteLine("Movimentações");
            foreach (Movimentacao mov in this.movimentacao)
            {
                Console.WriteLine($"Tipo: {mov.GetTipo()}; Valor: {mov.GetValor()}");
                Console.WriteLine();
            }
        }

    }
}
