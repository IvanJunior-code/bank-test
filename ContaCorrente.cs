using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank_test
{
    internal class ContaCorrente
    {
        /*
            A classe conterá métodos básicos para Depositar, Sacar e Transferir.
            Atributos agencia e numero não podem ser 0 e não podem ser números negativos.
            Não poderá depositar, sacar ou transferir valores negativos ou 0.
            A classe terá o método de contar quantas contas foram instanciadas.
            O saldo da conta não pode ser negativado.
        */

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
                if (ValidarValorMaiorQueSaldo(valor))
                {
                    return;
                }
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
                if (ValidarValorMaiorQueSaldo(valor))
                {
                    return;
                }
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

        private bool ValidarValorMaiorQueSaldo(int valor)
        {
            if (valor > Saldo)
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
