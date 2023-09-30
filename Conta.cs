using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX00
{
    public class Conta
    {
        //Propiedades
        public double Saldo { get; set; }
        public double Limite { get; set; } //Limite de credito que o Banco disponibilisa a um cliente!
        public int Numero { get; set; }

        //Metodos
        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return Saldo + Limite;
        }
    }
}
