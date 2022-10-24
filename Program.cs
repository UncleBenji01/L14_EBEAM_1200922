using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_EBEAM_1200922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion1;
            string[] puestos = new string[5];
            int[] salarios = new int[5];
            Console.WriteLine("Ingrese la opcion que desea: ");
            Console.WriteLine("Presione 1: = opcion1 " );
            Console.WriteLine("Presione 2: = opcion1 ");
            Console.WriteLine("Presione 3: = opcion1 ");
            opcion1 = Console.ReadLine();


            switch (opcion1)
            {
                case "1":
                    cargarvector cv= new cargarvector();
                    cv.vector1();
                    //Console.WriteLine("Ingresar :" + cv.vector1());
                    
                    break;

                case "2":
                   
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre del puesto : " + (i + 1));
                        puestos[i] = (Console.ReadLine());
                        Console.WriteLine("Ingrese el salario : " + (i + 1));
                        salarios[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("El Puesto :" + puestos[i] + " ,Tiene un salario de :" + salarios[i] );
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine(" Puede salir del programa");
                    Environment.Exit(0);
                    break;
            }

        }

        internal class cargarvector
        {
            string[] empleados = new string[5];
            int[] nacimiento = new int[5];
            public void vector1()
            {  string[] empleados = new string[5];
            int[] nacimiento = new int[5];
                int edad = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el Nombre de un empleado : " + (i + 1));
                    empleados[i] = (Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha de nacimiento: " + (i + 1));
                    nacimiento[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Nombre del empleado : " + empleados[i]);

                    Console.WriteLine("Fecha de nacimiento: " + nacimiento[i]);
                    edad = 2022 - nacimiento[i];
                    Console.WriteLine(" Su edad es : " + edad);
                }

                Console.ReadKey();
            }
        }
        
    }
}
