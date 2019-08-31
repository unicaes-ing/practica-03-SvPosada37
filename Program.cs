using System;

namespace Guia3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int horas;
            double minutos;
            double segundos;

            //Proceso
            Console.WriteLine("Bienvenido al sistema para convertir horas a segundos y minutos");
            Console.Write("\n¿Cúantas horas desea convertir? \n");
            horas = Convert.ToInt32(Console.ReadLine());

            minutos = horas * 60;
            Console.WriteLine("\nLa hora que usted digito tiene: {0} minutos", minutos);
            segundos = minutos * 60;
            Console.WriteLine("\nLa hora que usted digito tiene: {0} segundos", segundos);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\n ********************Ejercicio 2********************");
            Console.WriteLine();
            Ejercicio2.ejer2();
            Console.WriteLine("\n ********************Ejercicio 3********************");
            Console.WriteLine();
            Ejercicio3a.ejer3();
            Console.WriteLine("\n ********************Ejercicio 4********************");
            Console.WriteLine();
            Ejercicio4.ejer4();
            Console.WriteLine("\n ********************Ejercicio 5********************");
            Console.WriteLine();
            Ejercicio5.ejer5();
            Console.WriteLine("\n ********************Ejercicio 6********************");
            Console.WriteLine();
            Ejercicio6.ejer6();
            Console.WriteLine("\n ********************Ejercicio 7********************");
            Console.WriteLine();
            Ejercicio7.ejer7();
            Console.WriteLine("\n ********************Ejercicio 8********************");
            Console.WriteLine();
            Ejercicio8.ejer8();
        }
    }
}
