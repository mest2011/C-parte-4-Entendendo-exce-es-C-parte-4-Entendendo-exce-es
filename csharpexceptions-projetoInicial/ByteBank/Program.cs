
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(1, 1231);
                ContaCorrente conta2 = new ContaCorrente(351, 513513);

                conta2.Transferir(500, contaCorrente);

                contaCorrente.Depositar(50);
                Console.WriteLine(contaCorrente.Saldo);
               // contaCorrente.Sacar(500);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção!");
                Console.WriteLine("Nome da exceção: " + ex.ParamName);
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
