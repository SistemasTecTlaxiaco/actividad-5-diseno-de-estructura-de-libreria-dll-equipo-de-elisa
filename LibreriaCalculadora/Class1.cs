using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class Operaciones
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }
        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double mayor(double uno, double dos, double tres)
        {
            if (uno > dos && uno > tres)
            {
                return uno;
            }
            else
            {
                if (dos > uno && dos > tres)
                {
                    return dos;
                }
                else
                {
                    return tres;
                }
            }

        }

        public static double potencia(double Base, double exponente)
        {
            double resultado = Base;
            for (int i = 1; i < exponente; i++)
            {
                resultado *= Base;
            }
            return resultado;
        }

        public static double division(double divisor, double dividendo)
        {
            return divisor / dividendo;
        }

        public static double raizCuadrada(double numero)
        {
            double margen = 0.000001;
            double estimacion = 1.0;
            while (valorAbsoluto((estimacion * estimacion) - numero) >= margen)
            {
                double cociente = numero / estimacion;
                double promedio = (cociente + estimacion) / 2.0;
                //Console.WriteLine("estimacion " + estimacion + "cociente " + cociente + "promedio " + promedio);
                estimacion = promedio;
            }
            return estimacion;
        }
        private static double valorAbsoluto(double numero)
        {
            if (numero < 0)
            {
                return numero * -1;
            }
            return numero;
        }

        public static double porcentaje(double porciento, double porcentaje)
        {
            return (porcentaje * porciento) / 100;
        }

        public static double fraccion(double x)
        {
            return 1 / x;
        }

        public static double restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
    }
}
