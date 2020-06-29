using System;

namespace DiasQueQuedan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ndias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;

            Console.WriteLine("Dame el número del mes en el que quieres saber qué número de día faltan para acabarse el año \n" + "\nPresione: \n" +
            "1.Enero \n" + "2.Febrero \n" + "3.Marzo \n" + "4.Abril \n" + "5.Mayo \n" + "6.Junio \n" + "7.Julio \n" +
            "8.Agosto \n" + "9.Septiembre \n" + "10.Octubre \n" + "11.Noviembre \n" + "12.Diciembre \n" + "\n");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Elegiste Enero \n" + "Enero tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    int dia;
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[0] - dia + ndias[1] + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 2:
                    Console.WriteLine("Elegiste Febrero \n" + "Febrero tiene de 1 a 28 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 28 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[1] - dia + ndias[2] + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 3:
                    Console.WriteLine("Elegiste Marzo \n" + "Marzo tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[2] - dia + ndias[3] + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 4:
                    Console.WriteLine("Elegiste Abril \n" + "Abril tiene de 1 a 30 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[3] - dia + ndias[4] + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 5:
                    Console.WriteLine("Elegiste Mayo \n" + "Mayo tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[4] - dia + ndias[5] + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 6:
                    Console.WriteLine("Elegiste Junio \n" + "Junio tiene de 1 a 30 días" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[5] - dia + ndias[6] + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 7:
                    Console.WriteLine("Elegiste Julio \n" + "Julio tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[6] - dia + ndias[7] + ndias[8] + ndias[9] + ndias[10] + ndias[11]) +" dias");
                    break;
                case 8:
                    Console.WriteLine("Elegiste Agosto \n" + "Agosto tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[7] - dia + ndias[8] + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 9:
                    Console.WriteLine("Elegiste Septiembre \n" + "Septiembre tiene de 1 a 30 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[8] - dia + ndias[9] + ndias[10] + ndias[11]) + " dias");
                    break;
                case 10:
                    Console.WriteLine("Elegiste Octubre \n" + "Octubre tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[9] - dia + ndias[10] + ndias[11]) + " dias");
                    break;
                case 11:
                    Console.WriteLine("Elegiste Noviembre \n" + "Noviembre tiene de 1 a 30 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 30 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[10] - dia + ndias[11]) + " dias");
                    break;
                case 12:
                    Console.WriteLine("Elegiste Diciembre \n" + "Diciembre tiene de 1 a 31 días \n" + "\nAhora dame el día: \n");
                    dia = int.Parse(Console.ReadLine());
                    while (dia > 31 || dia < 0)
                    {
                        Console.WriteLine("Este mes no tiene esa cantidad de días \n" + "Ingresa un día válido");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elegiste el día: " + dia + " faltan " + (ndias[11] - dia) + " dias");
                    break;
                default:
                    Console.WriteLine("ERROR, lo que ingresaste no es un mes");
                    break;
            }
            Console.ReadKey();
        }
    }
}
