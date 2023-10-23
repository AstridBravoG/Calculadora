using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("---Calculadora basica---");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            //Se piden los numeros necesarios al usuario
            Console.WriteLine("------------------");
            Console.WriteLine("Ingreso de valores");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.Write("Ingresa el numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingresa el numero 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Operaciones suma, resta, multiplicacion, division
            Console.WriteLine("------------------");
            Console.WriteLine("---Resultados---");
            Console.WriteLine("------------------");
            double suma = num1 + num2;
            double rest = num1 - num2;
            double mult = num1 * num2;
            double divi = num1 / num2;

            //Resultados
            Console.WriteLine("La suma da: "+suma);
            Console.WriteLine();
            Console.WriteLine("La resta da: "+rest);
            Console.WriteLine();
            Console.WriteLine("La multiplicación da: "+mult);
            Console.WriteLine();
            Console.WriteLine("La division da: "+divi);

            //Leer el codigo / Mostrarlo
            Console.Read();



        }
    }
}
