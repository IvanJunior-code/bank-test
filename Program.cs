using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(10, 100);
            conta.Titular.Nome = "Titular 1";
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Numero: " + conta.Numero);
            Console.WriteLine("Titular: " + conta.Titular.Nome);
            Console.WriteLine("Conta Saldo: " + conta.Saldo);
            conta.Depositar(1111);
            Console.WriteLine("Conta Saldo: " + conta.Saldo + "\n");

            ContaCorrente conta2 = new ContaCorrente(20,100);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo);
            conta.Transferir(111, conta2);
            Console.WriteLine("Conta Saldo: " + conta.Saldo);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo + "\n");
            
            conta.Depositar(1);
            conta2.Depositar(9);
            Console.WriteLine("Conta Saldo: " + conta.Saldo);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo + "\n");
            
            conta.Sacar(301);
            conta2.Sacar(20);
            Console.WriteLine("Conta Saldo: " + conta.Saldo);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo + "\n");
            
            conta2.Transferir(101, conta);
            Console.WriteLine("Conta Saldo: " + conta.Saldo);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo + "\n");

            conta2.Transferir(100, conta);
            Console.WriteLine("Conta2 Saldo: " + conta2.Saldo + "\n");

            ContaCorrente conta3 = new ContaCorrente(333, 333111);
            ContaCorrente conta4 = new ContaCorrente(444, 444111);
            Console.WriteLine("Quantidade de contas: " + ContaCorrente.QuantidadeDeContas);


            Console.ReadKey();
        }
    }
}
