using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio4
    {
        public static void ejer4()
        {
            int duracion;
            double costo;
            int zona;
            Console.Write("Ingrese la duración en minutos: ");
            duracion = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("Elija su ubicación: \n dijite el número de la opcción \n");
            Console.Write("1. Zona Occidental   \n2. Zona Oriental    \n3. Zona Central\n");
            zona = Convert.ToInt32(System.Console.ReadLine());

            if (zona == 1)
            {
                costo = (0.32 * duracion);
                Console.WriteLine("El costo total de la llamada es: {0}", costo);
            }
            Console.ReadKey();

            if (zona == 2)
            {
                costo = (0.36 * duracion);
                Console.WriteLine("El costo total de la llamada es: {0}", costo);
            }
            Console.ReadKey();

            if (zona == 3)
            {
                costo = (0.25 * duracion);
                Console.WriteLine("El costo total de la llamada es: {0}", costo);
            }
            Console.ReadKey();
        }
    }
}
