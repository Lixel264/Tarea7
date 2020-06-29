using System;

namespace EncimaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 10 números, te diré su media aritmética y te mostraré los que están por encima de esta");

            int[] numeros = new int[10];
            double sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingresa un número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                sum += numeros[i];
            }
            sum = sum / 10;
            Console.WriteLine("\n" + "La media de estos números es " + sum + "\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > sum )
                {
                    Console.WriteLine(numeros[i] + " es mayor que " + sum);
                }
            }
            Console.ReadKey();
        }
    }
}
