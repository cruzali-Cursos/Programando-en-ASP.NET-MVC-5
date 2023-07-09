using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore01.Models;

namespace WebCore01.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Monsters INC",
                Duracion = 165,
                Pais = "USA",
                Publicacion = new DateTime(2016, 10, 29)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Buscando a Nemo",
                Duracion = 205,
                Pais = "USA",
                Publicacion = new DateTime(2011, 01, 08)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }



    }
}
