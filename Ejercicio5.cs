using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio5
    {
        public static void ejer5()
        {
            int numero;
            Console.WriteLine("Porfavor ingrese un número entero entre 1 a 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Uno");
            }

            if (numero == 2)
            {
                Console.WriteLine("Dos");
            }

            if (numero == 3)
            {
                Console.WriteLine("Tres");
            }

            if (numero == 4)
            {
                Console.WriteLine("Cuatro");
            }

            if (numero == 5)
            {
                Console.WriteLine("Cinco");
            }

            if (numero == 6)
            {
                Console.WriteLine("Seis");
            }

            if (numero == 7)
            {
                Console.WriteLine("Siete");
            }

            if (numero == 8)
            {
                Console.WriteLine("Ocho");
            }

            if (numero == 9)
            {
                Console.WriteLine("Nueve");
            }

            if (numero == 10)
            {
                Console.WriteLine("Diez");
            }
            Console.ReadKey();
        }
    }
}
