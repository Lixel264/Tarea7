using System;

namespace DiasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            Console.WriteLine("Los días de la semana son: ");

            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }
            Console.ReadKey();
        }
    }
}
