using System;

namespace Exercicio02
{
    public class Vagao : Transporte
    {
        public double frete;

        public override void calculaFrete(int distancia)
        {
            frete = (0.07 * objCarga.Peso) + (0.01 * objCarga.Valor) + (0.5 * distancia);

            if (objCarga.Peso < 15000)
            {
                frete += 5000;
            }

            Console.WriteLine("Frete vagão: R$" + Math.Round(frete),2);
        }
    }
}