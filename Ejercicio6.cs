using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio6
    {
        public static void ejer6()
        {
            double monto;
            Console.WriteLine("Ingrese el monto de su compra:");
            monto = Convert.ToDouble(Console.ReadLine());
            if (monto >= 0 && monto <= 100)
            {
                Console.WriteLine("\nComo su monto de compra es menor de $100 no se le aplicó descuento.");
                Console.WriteLine("Su total a pagar: {0:C2}", monto);
            }

            if (monto > 100 && monto <= 200)
            {
                Console.WriteLine("Como su monto de compra está entre $100 y $200 se le aplicó un descuento del 12%: {0:C2}", (monto * 0.12));
                monto = monto + (monto * 0.12);
                Console.WriteLine("Su total a pagar: {0:C2}", monto);
            }

            if (monto > 200 && monto <= 500)
            {
                Console.WriteLine("Como su monto de compra está entre $200 y $500 se le aplicó un descuento del 15%: {0:C2}", (monto * 0.15));
                monto = monto + (monto * 0.15);
                Console.WriteLine("Su total a pagar: {0:C2}", monto);
            }

            if (monto > 500)
            {
                Console.WriteLine("Como su monto de compra está de $500 o más se le aplicó un descuento del 12%: {0:C2}", (monto * 0.2));
                monto = monto + (monto * 0.2);
                Console.WriteLine("Su total a pagar: {0:C2}", monto);
            }
            Console.ReadKey();
        }
    }
}
