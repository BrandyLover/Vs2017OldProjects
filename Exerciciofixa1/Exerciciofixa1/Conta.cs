using System;
using System.Globalization;

namespace Exerciciofixa1 {
    class Conta {
        public int numConta { get; private set; }
        public string nomeConta;
        public double saldoConta { get; private set; }
        public override string ToString() {
            return "Conta " + numConta
                + ", Titular: " + nomeConta
                + ", Saldo: $ " + saldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }

        public Conta(int numConta,string nomeConta,double depoIniConta) {
            this.numConta = numConta;
            this.nomeConta = nomeConta;
            saldoConta = depoIniConta;
        }
        public Conta(int numConta,string nomeConta) {
            this.numConta = numConta;
            this.nomeConta = nomeConta;
            saldoConta = 0;
        }

        public void depositoConta(double valor) {
            saldoConta += valor;
        }
        public void saqueConta(double valor) {
            saldoConta -= valor + 5;     
        }
    }
}
