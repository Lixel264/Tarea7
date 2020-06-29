using System;

namespace OrdenContrario
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            Console.WriteLine("Dame 5 números");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n" + "\nSu orden invertido es: \n" + "\n");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
