using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace contaBancaria {
    internal class ContaBancaria {

        //Encapsulamento numero da conta GET pode ser acessado e SET como private não pode ser alterado
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        //Construtor com 2 argumentos
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        //construtor com 3 argumentos e utilizando a palavra THIS para reaproveitas do contrutor de 2 argumentos
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;


        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5.0;
        }



        public override string ToString() {
            return " Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
