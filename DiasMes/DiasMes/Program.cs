using System;

namespace DiasMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ndias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;

            Console.WriteLine("Dame el número del mes en el que quieres saber cuantos dias tiene \n" + "\nPresione: \n" +
                "1.Enero \n" + "2.Febrero \n" + "3.Marzo \n" + "4.Abril \n" + "5.Mayo \n" + "6.Junio \n" + "7.Julio \n" + 
                "8.Agosto \n" + "9.Septiembre \n" + "10.Octubre \n" + "11.Noviembre \n" + "12.Diciembre \n" + "\n");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Elegiste Enero \n" + "\nEnero tiene " + ndias[0] + " dias");
                    break;
                case 2:
                    Console.WriteLine("Elegiste Febrero \n" + "\nFebrero tiene " + ndias[1] + " dias");
                    break;
                case 3:
                    Console.WriteLine("Elegiste Marzo \n" + "\nMarzo tiene " + ndias[2] + " dias");
                    break;
                case 4:
                    Console.WriteLine("Elegiste Abril \n" + "\nAbril tiene " + ndias[3] + " dias");
                    break;
                case 5:
                    Console.WriteLine("Elegiste Mayo \n" + "\nMayo tiene " + ndias[4] + " dias");
                    break;
                case 6:
                    Console.WriteLine("Elegiste Junio \n" + "\nJunio tiene " + ndias[5] + " dias");
                    break;
                case 7:
                    Console.WriteLine("Elegiste Julio \n" + "\nJulio tiene " + ndias[6] + " dias");
                    break;
                case 8:
                    Console.WriteLine("Elegiste Agosto \n" + "\nAgosto tiene " + ndias[7] + " dias");
                    break;
                case 9:
                    Console.WriteLine("Elegiste Septiembre \n" + "\nSeptiembre tiene " + ndias[8] + " dias");
                    break;
                case 10:
                    Console.WriteLine("Elegiste Octubre \n" + "\nOctubre tiene " + ndias[9] + " dias");
                    break;
                case 11:
                    Console.WriteLine("Elegiste Noviembre \n" + "\nNoviembre tiene " + ndias[10] + " dias");
                    break;
                case 12:
                    Console.WriteLine("Elegiste Diciembre \n" + "\nDiciembre tiene " + ndias[11] + " dias");
                    break;
                default:
                    Console.WriteLine("ERROR, lo que ingresaste no es un mes");
                    break;
            }
            Console.ReadKey();
        }
    }
}
