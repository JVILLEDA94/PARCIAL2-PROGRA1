using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Class1
    {
        public void Clase1()
        {
            int valor1, valor2;

            Console.WriteLine("Ingresa un numero para multiplicar");
            valor1 = int.Parse(Console.ReadLine());

            switch (valor1)
            {
                case 0:
                    Console.WriteLine("El producto de 0 por cualquier numero es 0");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ingrese un segundo valor");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("La multiplicacion de " + valor1 + " por " + valor2 + " es igual a: " + (valor1 * valor2));
                    Console.ReadKey();
                    break;
            }

        }

        public void Clase2()
        {
            int valor1, valor2;

            Console.WriteLine("Ingresa dos numeros enteros");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("ERROR: No se puede dividir entre cero");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La division entre " + valor1 + " entre " + valor2 + " es: " + (valor1 / valor2));
                Console.ReadKey();
            }
        }

        public void Clase3()
        {
            string[] a = new string[40];
            Console.WriteLine("Ingrese 5 nombres de alumnos");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese alumno " + i);
                a[i] = (Console.ReadLine());
            }
            Console.WriteLine("Alumnos registrados");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }

        public void Clase4()
        {
            int[] a = new int[40];
            int i = 1, j = 1;
            Console.WriteLine("Ingrese 5 edades de alumnos");

            do
            {
                Console.WriteLine("Ingrese alumno " + i);

                a[i] = int.Parse(Console.ReadLine());
                i++;
            } while (i <= 5);

            Console.WriteLine("Edades registradas");

            do
            {
                Console.WriteLine(a[j]);
                j++;
            } while (j <= 5);
            Console.ReadKey();
        }
    }
}
