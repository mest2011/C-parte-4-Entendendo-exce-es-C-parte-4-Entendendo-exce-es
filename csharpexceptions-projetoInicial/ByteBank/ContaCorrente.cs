// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia não pode ser igual ou menor que zero!", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero não pode ser igual ou menor que zero!", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor para saque deve ser um numero igual ou maior que 0!", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(valor, _saldo);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para transferencia! valor deve ser maior que 0", nameof(valor));
            }
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
