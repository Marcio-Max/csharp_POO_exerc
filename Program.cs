using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX00
{
    internal class Program //classe de inicializacao
    {
        static void Main(string[] args)
        {   
            //Criando instancias da classe Conta
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();

            //valores conta1 
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            //valores conta2 
            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 456;

            Console.WriteLine(" Ola fulano o seu saldo e de: " + conta1.Saldo);
            Console.WriteLine($" Limite de saque e de: {conta1.Limite}");
            Console.WriteLine($" O numero da conta e: {conta1.Numero}");

            Console.WriteLine("\n-------------------------------------------------");

            Console.WriteLine(" Ola fulano o seu saldo e de: " + conta2.Saldo);
            Console.WriteLine($" Limite de saque e de: {conta2.Limite}");
            Console.WriteLine($" O numero da conta e: {conta2.Numero}");




            Console.ReadKey();
        }
    }
}
