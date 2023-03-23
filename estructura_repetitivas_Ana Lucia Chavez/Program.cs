using System;

namespace Estructuras_Repetitivas
{
    class Ejercicios
    {
        // Metodo 1: Usando do-while
        public static void NumerosPares()
        {
            int num;
            Console.WriteLine("Trabajo Supervisado - Ana Lucia Chavez");
            do
            {
                Console.Write("Ingresa un número (99 para salir): ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0 && num != 99)
                {
                    Console.WriteLine("Número par: " + num);
                }
            } while (num != 99);
        }

        // Metodo 2: Usando for
        public static void ImprimirFilas()
        {
            Console.Write("Ingresa el número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        // Metodo 3: Usando for
        public static void SumaDivisiblesEntre9()
        {
            int suma = 0;
            Console.WriteLine("Números divisibles entre 9 entre 100 y 200:");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                    suma += i;
                }
            }
            Console.WriteLine("\nSuma de los números divisibles entre 9: " + suma);
        }

        // Método 4: Usando while
        public static void TablaMultiplicar()
        {
            Console.Write("Ingresa un número del 1 al 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine("Tabla de multiplicar del número " + i + ":");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
                i++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Llamando a los métodos de la clase Ejercicios
            Ejercicios.NumerosPares();
            Ejercicios.ImprimirFilas();
            Ejercicios.SumaDivisiblesEntre9();
            Ejercicios.TablaMultiplicar();
        }
    }
}
