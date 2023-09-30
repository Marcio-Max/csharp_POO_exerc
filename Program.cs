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
            Conta conta = new Conta();
            conta.AdicionarLimite(1500);

            conta.Deposita(1500);
            bool sacar = conta.Sacar(4300);
          
            if (sacar)
            {
                Console.WriteLine(" Saque com SUCESSO!");
                Console.WriteLine(" O Saldo atual de: " + conta.ConsultaSaldoDisponivel());

                //Console.WriteLine(" O Saldo e de: " + conta.Saldo);
                //Console.WriteLine(" O Limite e de: " + conta.Limite);
                //Console.WriteLine(sacar);
            }






            Console.ReadKey();
        }
    }
}
