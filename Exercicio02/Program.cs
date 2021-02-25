using System;

namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caminhao objCaminhao = new Caminhao();
            Console.WriteLine("Informe a distancia percorrida pelo caminhão: ");
            int distanciaCaminhao = Convert.ToInt32(Console.ReadLine());
            objCaminhao.calculaFrete(distanciaCaminhao);

            Vagao objVagao = new Vagao();
            Console.WriteLine("Informe a distancia percorrida pelo vagão: ");
            int distanciaVagao = Convert.ToInt32(Console.ReadLine());
            objVagao.calculaFrete(distanciaVagao);
        }
    }
}