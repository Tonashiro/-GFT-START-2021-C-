using System;

namespace Exercicio02
{
    public class Caminhao : Transporte
    {
        public double freteCaminhao;

        public override void calculaFrete(int distancia)
        {
            freteCaminhao = (0.02 * objCarga.Peso) + (0.03 * objCarga.Valor) + (2 * distancia);

            if (objCarga.Valor > 40000)
            {
                freteCaminhao -= freteCaminhao * 0.25;
            }

            Console.WriteLine("Frete caminhão: R$" + freteCaminhao);
        }
    }
}