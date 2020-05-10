
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(1, 0);
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
