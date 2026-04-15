using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("eliga su estado civil");
                Console.WriteLine("a) soltero");
                Console.WriteLine("b) viudo");
                Console.WriteLine("c) divorciado");
                Console.WriteLine("d) sin especificar");


                char opcion =
                    Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (opcion)
                {
                    case 'a':

                        break;

                    case 'b':
                        Console.WriteLine("casado");
                        break;

                    case 'c':
                        Console.WriteLine("viudo");
                        break;
                    case 'd':
                        Console.WriteLine("divorciado");
                        break;
                    case 'e':
                        Console.WriteLine("sin especificar");
                        break;
                    default:
                        Console.WriteLine("no hay accion");
                        break;
                }
                Console.WriteLine("presione cualquier boton para salir");
                Console.ReadKey();







                //double edad;
                //Console.WriteLine(" ingrese su edad: ");
                //edad = double.Parse(Console.ReadLine());
                //if (edad >= 18)
                //{

                //    Console.WriteLine("elija una pelicula");
                //    {


                //        Console.WriteLine("a) persona1");
                //        Console.WriteLine("b) vxdd");
                //        Console.WriteLine("c) divorciadol apelicula");
                //        Console.WriteLine("d) sin especificarcdddddddddd");


                //        char opcion =
                //            Console.ReadKey().KeyChar;
                //        Console.WriteLine();
                //        switch (opcion)
                //        {
                //            case 'a':

                //                break;

                //            case 'b':
                //                Console.WriteLine("casado");
                //                break;

                //            case 'c':
                //                Console.WriteLine("viudo");
                //                break;
                //            case 'd':
                //                Console.WriteLine("divorciado");
                //                break;
                //            case 'e':
                //                Console.WriteLine("sin especificar");
                //                break;
                //            default:
                //                Console.WriteLine("no hay accion");
                //                break;
                //        }
                //        Console.WriteLine("presione cualquier boton para salir");
                //        Console.ReadKey();
                //    }


                //}
                //else if (edad <= 18)
                //{
                //    Console.WriteLine("no tiene edad");
                //}
            }
            //string nombre;
            //Console.WriteLine("ingrese su nombre ");
            //nombre = Console.ReadLine();
            //if (nombre == "ana")
            //{
            //    Console.WriteLine("buenos dias ana");
            //}
            //else 
            //{
                
            //    Console.WriteLine("hola " + nombre + " no te conosco" );
             
            //}
          
            
            
           
        }
    }
}
