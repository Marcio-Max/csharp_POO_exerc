﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX00
{
    public class Conta
    {
        //Propiedades
        private double Saldo { get; set; }
        public double Limite { get; private set; } //Limite de credito que o Banco disponibilisa a um cliente!
        public int Numero { get; set; }

        //Metodos
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
         
        public double ConsultaSaldoDisponivel()
        {
            return Saldo + Limite;
        }

        public double AdicionarLimite( double valor )
        {
            return  Limite = valor;
        }

        public bool Sacar( double valor )
        {
            double saldoDisponivel = ConsultaSaldoDisponivel();
            if(saldoDisponivel < valor)
            {
                Console.WriteLine(" Saldo e saque Indisponivel!");
                return false;

            }else Saldo -= valor;
            return true;   
           
        }
    }
}
