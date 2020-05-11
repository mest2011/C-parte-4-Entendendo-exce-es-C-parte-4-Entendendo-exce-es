
using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH DO BLOCO MAIN!");
            }
            

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("Arquivo.txt"))
            {
                leitor.LerProximaLinha();
            }






            //--------------------------------------------------
            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Ocorreu uma exceção do tipo IOExcepition.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}
            
        }
        public void TestarInnerException()
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
        }
    }
}
