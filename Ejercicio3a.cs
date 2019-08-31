using System;
using System.Collections.Generic;
using System.Text;

namespace Guia3
{
    class Ejercicio3a
    {
       
            public static void ejer3()
            {
                //Variables
                int num1;
                int num2;
                int num3;
            Console.WriteLine();
            Console.WriteLine("\nPor favor ingrese 3 números:");
                //Proceso
                Console.Write("Escriba el primer numero número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEscriba el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEscriba tercer número: ");
                num3 = Convert.ToInt32(Console.ReadLine());


                //Mostrar datos

                if (num1 < num2 && num1 < num3)
                {
                Console.WriteLine();
                    Console.WriteLine(num1);
                }
                else
                {
                    if (num2 < num1 && num2 < num3)
                    {
                        Console.WriteLine(num2);
                    }
                    else
                    {
                        if (num3 < num1 && num3 < num2)
                        {
                            Console.WriteLine(num3);
                        }
                    }
                }
                if (num1 > num2 && num1 < num3)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    if (num2 > num1 && num2 < num3)
                    {
                        Console.WriteLine(num2);
                    }
                    else
                    {
                        if (num3 > num1 && num3 < num2)
                        {
                            Console.WriteLine(num3);
                        }
                    }
                }

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine(num1);
                }

                else
                {
                    if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine(num2);
                    }
                    else
                    {
                        if (num3 > num1 && num3 > num2)
                        {
                            Console.WriteLine(num3);
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }


