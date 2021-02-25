using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do multiplicando: ");
            int multiplicando = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor inicial dos multiplicadores: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor final dos multiplicadores: ");
            int fim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplicando: " + multiplicando);
            Console.WriteLine("Início do intervalo: " + inicio);
            Console.WriteLine("Fim do intervalo: " + fim);
            Console.WriteLine("----------");

            int resultado = 0;

            if (multiplicando > 0 && multiplicando < 3000 &&
                inicio > 0 && inicio < 3000 && fim > 0 && fim < 3000 &&
                (inicio - fim) <= 10 && inicio < fim)
            {
                for (int i = inicio; i <= fim; i++) 
                {
                    resultado = multiplicando * i;
                    Console.WriteLine(multiplicando + " x " + i + " = " + resultado);
                }              
            }
            else
            {
                Console.WriteLine("\nDados inválidos!");
            }
            Console.WriteLine("----------");
        }
    }
}
