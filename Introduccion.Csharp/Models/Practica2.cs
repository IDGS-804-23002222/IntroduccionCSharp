using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Models
{
        /*
         * class[nombre] {
         * [atributos o variables]
         * [metodos o funciones]
         * 
         */
        internal class Practica2
        {
            string nombre;
            private int edad;
            protected string carrera;

            public void IngresarDatos()
            {
                Console.WriteLine("Ingresa tu nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu carrera: ");
                carrera = Console.ReadLine();
            }

            public void MostrarDatos()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Carrera: " + carrera);

            }


        }
    }