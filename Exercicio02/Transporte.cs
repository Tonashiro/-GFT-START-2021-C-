using System;

namespace Exercicio02
{
    public abstract class Transporte
    {
        public Carga objCarga = new Carga();

        public Transporte()
        {
            Console.WriteLine("Informe o peso da carga: ");
            objCarga.Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor da carga: ");
            objCarga.Valor = Convert.ToDouble(Console.ReadLine());
        }

        public abstract void calculaFrete(int distancia);
    }
}