using System;


namespace fixa2 {
    class Registro {
        public string nome, email;
        public int nquarto;
        public Registro(string nome,string email,int nquarto) {
            this.nome = nome;
            this.nquarto = nquarto;
            this.email = email;
        }
        public override string ToString() {
            return nquarto + ": " + nome + ", " + email;
        }
    }

}
