
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1, 1231);
                ContaCorrente conta2 = new ContaCorrente(351, 513513);

                conta1.Transferir(1000, conta2);
                conta2.Sacar(500);
                
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
