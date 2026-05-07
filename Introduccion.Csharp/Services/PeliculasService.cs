using Introduccion.Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Services
{
    public class PeliculasService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = "120",
                Publicacion = new DateTime(2013, 12, 5),
                Pais = "USA"
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = "111",
                Publicacion = new DateTime(2015, 05, 5),
                Pais = "USA"
            };

            return new List<Pelicula>()
            {
                pelicula1,
                pelicula2
            };

        }
    }
}