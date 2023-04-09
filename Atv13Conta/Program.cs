namespace Atv13Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movimentacao[] arrayMov = new Movimentacao[3];

            Movimentacao mov1 = new Movimentacao(200, "credito");
            arrayMov[0] = mov1;

            Movimentacao mov2 = new Movimentacao(300, "credito");
            arrayMov[1] = mov2;

            Movimentacao mov3 = new Movimentacao(100, "debito");
            arrayMov[2] = mov3;

            ContaCorrente conta1 = new ContaCorrente(1000, 12, 0, true, arrayMov);

            conta1.Sacar(200);
            conta1.Depositar(300);
            conta1.Depositar(500);
            conta1.Sacar(200);

            ContaCorrente conta2 = new ContaCorrente(300, 13, 0, true, arrayMov);

            conta1.TransferirPara(conta2, 400);

            conta1.ExibirExtrato();

            
            Console.ReadLine();
        }
    }
}