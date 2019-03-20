using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace PARCIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            int seleccione;

            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1- Ejercicio 1");
            Console.WriteLine("2- Ejercicio 2");
            Console.WriteLine("3- Ejercicio 3");
            Console.WriteLine("4- Ejercicio 4");
            seleccione = int.Parse(Console.ReadLine());

            switch (seleccione)
            {
                case 1:
                    obj.Clase1();
                    break;
                case 2:
                    obj.Clase2();
                    break;  
                case 3:
                    obj.Clase3();
                    break;
                case 4:
                    obj.Clase4();
                    break;
                default:
                    Console.WriteLine("Error al seleccionar");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
