using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio2
        

    {
        public static void ejer2()
        {
            Random numero = new Random();
            int numerorandom = numero.Next(100);
            Console.WriteLine(numerorandom);
          
            if (numerorandom % 2 == 0)
            {
                Console.Write("\nEl número que se generó automaticamente es par");
            }
            else
            {
                Console.Write("\nEl número que se generó automaticamente es impar");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
