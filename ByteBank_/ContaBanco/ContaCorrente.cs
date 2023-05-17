using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_.Titular;

namespace ByteBank_.ContaBanco
{
    internal class ContaCorrente
    {
        public static int totalContasCriadas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set
            { 
                if(value < 0)
                {
                    this.numeroAgencia = value;
                }
            }
        }
        public string Conta { get; private set; }
        private double saldo;
        public PessoaFisica Titular { get; set; }

        public ContaCorrente(int numero_agencia, string numero_conta) 
        {
            this.NumeroAgencia = numero_agencia;
            this.Conta = numero_conta;

            totalContasCriadas++;
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            } else
            {
                this.saldo = valor;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
