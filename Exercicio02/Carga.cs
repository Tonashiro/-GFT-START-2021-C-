using System;

namespace Exercicio02
{
    public class Carga
    {

        public Carga()
        {
            this.Peso = 0;
            this.Valor = 0;
        }

        public double peso;
        public double valor;

        public double Peso
        {
            get {return peso;}
            set {peso = value;}
        }

        public double Valor
        {
            get {return valor;}
            set {valor = value;}
        }
    }
}