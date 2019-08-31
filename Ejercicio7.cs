using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio7
    {
        public static void ejer7()
        {
            int unidad_inicial, unidad_final;
            double cantidad;
            Console.WriteLine("Bienvenido al converidor de unidades");
            Console.WriteLine("\nIngrese la unidad:\n1. Onza\n2. Libra\n3. Gramo\n4. Tonelada");
            unidad_inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese la cantidad:");
            cantidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIngrese la unidad de conversión:\n1. Onza\n2. Libra\n3. Gramo\n4. Tonelada");
            unidad_final = Convert.ToInt32(Console.ReadLine());
            double resultado;

            if (unidad_inicial == 1 && unidad_final == 2)
            {
                resultado = cantidad * 0.0625;
                Console.WriteLine("\nEn {0} onzas hay {1:N2} libras", cantidad, resultado);
            }
            if (unidad_inicial == 1 && unidad_final == 3)
            {
                resultado = cantidad * 28.3495;
                Console.WriteLine("\nEn {0} onzas hay {1:N2} gramos", cantidad, resultado);
            }
            if (unidad_inicial == 1 && unidad_final == 4)
            {
                resultado = cantidad * 0.00002834;
                Console.WriteLine("\nEn {0} onzas hay {1:N6} toneldas", cantidad, resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 1)
            {
                resultado = cantidad * 16;
                Console.WriteLine("\nEn {0} libras hay {1} onzas", cantidad, resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 3)
            {
                resultado = cantidad * 453.592;
                Console.WriteLine("\nEn {0} libras hay {1:N2} gramos", cantidad, resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 4)
            {
                resultado = cantidad * 0.0004535;
                Console.WriteLine("\nEn {0} libras hay {1:N4} onzas", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 1)
            {
                resultado = cantidad * 0.03527;
                Console.WriteLine("\nEn {0} gramos hay {1:N2} onzas", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 2)
            {
                resultado = cantidad * 0.0022;
                Console.WriteLine("\nEn {0} gramos hay {1:N2} libras", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 4)
            {
                resultado = cantidad * 0.000001;
                Console.WriteLine("\nEn {0} gramos hay {1:N6} toneladas", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 1)
            {
                resultado = cantidad * 35274;
                Console.WriteLine("\nEn {0} toneladas hay {1} onzas", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 2)
            {
                resultado = cantidad * 2204.62;
                Console.WriteLine("\nEn {0} toneldas hay {1:N2} libras", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 3)
            {
                resultado = cantidad * 1000000;
                Console.WriteLine("\nEn {0} toneldas hay {1} gramos", cantidad, resultado);
            }
            if (unidad_inicial == unidad_final)
            {
                Console.WriteLine("\nLas unidades de medida son iguales");
            }
            Console.ReadKey();
        }
    }
}
