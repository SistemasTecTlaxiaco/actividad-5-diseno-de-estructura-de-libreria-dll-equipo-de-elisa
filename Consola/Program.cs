﻿using System;
using LibreriaCalculadora;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        private static double num1 = 0, num2 = 0, num0 = 0;
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.WriteLine("-----------MENU PRINCIPAL TEC de TLAXIACO---------------");
                    Console.WriteLine("1. Sumar dos numeros");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Raiz Cuadrada");
                    Console.WriteLine("6. Potencia");
                    Console.WriteLine("7. Porcentaje");
                    Console.WriteLine("8. Fraccion");
                    Console.WriteLine("9. Logaritmo Base 10");
                    Console.WriteLine("10. Coseno");
                    Console.WriteLine("11. Seno");
                    Console.WriteLine("12. Salida");
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            teclado1();
                            Console.WriteLine("El resultado de la suma es: " + Operaciones.sumar(num1, num2));
                            break;
                        case 2:
                            teclado1();
                            Console.WriteLine("El resultado de la Resta es: " + Operaciones.restar(num1, num2));
                            break;
                        case 3:
                            teclado1();
                            Console.WriteLine("El resultado de la Multiplicacion es: " + Operaciones.multiplicar(num1, num2));
                            break;
                        case 4:
                            teclado1();
                            Console.WriteLine("El resultado de la Division es: " + Operaciones.division(num1, num2));
                            break;
                        case 5:
                            teclado0();
                            Console.WriteLine("El resultado de la Raiz cuadrada es: " + Operaciones.raizCuadrada(num0));
                            break;
                        case 6:
                            teclado1();
                            Console.WriteLine("El resultado de la Potencia es: " + Operaciones.potencia(num1, num2));
                            break;
                        case 7:
                            teclado1();
                            Console.WriteLine("El resultado del porcentaje es: " + Operaciones.porcentaje(num1, num2));
                            break;
                        case 8:
                            teclado0();
                            Console.WriteLine("El resultado de la fraccion es: " + Operaciones.fraccion(num0));
                            break;
                        case 9:
                            teclado0();
                            Console.WriteLine("El resultado del logaritmo base 10 es: " + Operaciones.logaritmoBase10(num0));
                            break;
                        case 10:
                            teclado0();
                            Console.WriteLine("El resultado del coseno es: " + Operaciones.coseno(num0));
                            break;
                        case 11:
                            teclado0();
                            Console.WriteLine("El resultado del seno es: " + Operaciones.seno(num0));
                            break;
                        case 12:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            Environment.Exit(1);
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 12");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error al ingresar!!");
                }
            }
        }

        private static void teclado0()
        {
            Console.WriteLine("Introduzca un numero");
            num0 = double.Parse(Console.ReadLine());
        }
        private static void teclado1()
        {
            Console.WriteLine("Introduzca el primer numero por favor ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = double.Parse(Console.ReadLine());
        }
    }
}
