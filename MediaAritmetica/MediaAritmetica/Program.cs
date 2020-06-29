using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 4 números y te diré su media aritmética");

            int[] numeros = new int[4];
            double sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingresa un número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
                sum += numeros[i];
            }
            double media = sum / 4;
            Console.WriteLine("La media aritmética de estos números es: " + media);
            Console.ReadKey();
        }
    }
}
