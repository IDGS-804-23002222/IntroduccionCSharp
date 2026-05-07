using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Models
{
        internal class Practica1
        {
            // int, string, char, double, bool
            static void Main(String[] args)
            {
                Practica2 p2 = new Practica2();
                p2.IngresarDatos();
                p2.MostrarDatos();
                
            /*
                int cal1 = 0;
                int cal2, cal3, resultado, x, y, f;
                string dato1;


                Console.WriteLine("ingresa primera calificacion: ");
                dato1 = Console.ReadLine();
                cal1 = Convert.ToInt32(dato1);
                Console.WriteLine("Ingresa segunda calificacion: ");
                dato1 = Console.ReadLine();
                cal2 = Convert.ToInt32(dato1);
                resultado = cal1 + cal2;

                Console.WriteLine("La suma de calificaciones es: " + resultado);

                // if else
                if (cal1 > cal2)
                {
                    Console.WriteLine("La nota mayor es: " + cal1);
                }
                else
                {
                    Console.WriteLine("La nota mayor es: " + cal2);
                }

                // while
                x = 1;
                while (x <= 100)
                {
                    Console.Write(x);
                    Console.Write(" - ");
                    x++;
                }

                // do while
                y = 1;
                do
                {
                    Console.Write(y);
                    Console.Write(" - ");
                    y++;
                } while (y <= 100);
                // for
                for (f = 1; f <= 100; f++)
                {
                    Console.Write(f);
                    Console.Write(" - ");
                }
                */
            }
        }
    }