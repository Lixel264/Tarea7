using System;

namespace TotalDiasMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ndias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;

            Console.WriteLine("Dame el número del mes en el que quieres saber qué número de día es dentro del año \n" + "\nPresione: \n" +
            "1.Enero \n" + "2.Febrero \n" + "3.Marzo \n" + "4.Abril \n" + "5.Mayo \n" + "6.Junio \n" + "7.Julio \n" +
            "8.Agosto \n" + "9.Septiembre \n" + "10.Octubre \n" + "11.Noviembre \n" + "12.Diciembre \n" + "\n");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Elegiste Enero \n" + "\nAhora dame el día: \n");
                    int dia;
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + dia + " del año");
                    break;
                case 2:
                    Console.WriteLine("Elegiste Febrero \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 28 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0]) + " del año");
                    break;
                case 3:
                    Console.WriteLine("Elegiste Marzo \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1]) + " del año");
                    break;
                case 4:
                    Console.WriteLine("Elegiste Abril \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2]) + " del año");
                    break;
                case 5:
                    Console.WriteLine("Elegiste Mayo \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3]) + " del año");
                    break;
                case 6:
                    Console.WriteLine("Elegiste Junio \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4]) + " del año");
                    break;
                case 7:
                    Console.WriteLine("Elegiste Julio \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5]) + " del año");
                    break;
                case 8:
                    Console.WriteLine("Elegiste Agosto \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias [6]) + " del año");
                    break;
                case 9:
                    Console.WriteLine("Elegiste Septiembre \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7]) + " del año");
                    break;
                case 10:
                    Console.WriteLine("Elegiste Octubre \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8]) + " del año");
                    break;
                case 11:
                    Console.WriteLine("Elegiste Noviembre \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9]) + " del año");
                    break;
                case 12:
                    Console.WriteLine("Elegiste Diciembre \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("El día: " + dia + " es el día número " + (dia + ndias[0] + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10]) + " del año");
                    break;
                default:
                    Console.WriteLine("ERROR, lo que ingresaste no es un mes");
                    break;
            }
            Console.ReadKey();
        }
    }
}
