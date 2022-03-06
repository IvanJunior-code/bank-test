using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank_test
{
    internal class ContaCorrente
    {
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            QuantidadeDeContas++;
        }

        public Cliente Titular = new Cliente();


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (ValidarValorIncorreto(value))
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }


        private int _numero;
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (ValidarValorIncorreto(value))
                {
                    return;
                }
                else
                {
                    _numero = value;
                }
            }
        }


        public int Saldo { get; private set; }


        public void Depositar(int valor)
        {
            if (ValidarValorIncorreto(valor))
            {
                return;
            }
            else
            {
                Saldo += valor;
            }
        }


        public void Sacar(int valor)
        {
            if (ValidarValorIncorreto(valor))
            {
                return;
            }
            else
            {
                Saldo -= valor;
            }

        }


        public void Transferir(int valor, ContaCorrente contaDestino)
        {
            if (ValidarValorIncorreto(valor))
            {
                return;
            }
            else
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            }
        }


        private bool ValidarValorIncorreto(int valor)
        {
            if (valor <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int QuantidadeDeContas { get; private set; }

    }
}
