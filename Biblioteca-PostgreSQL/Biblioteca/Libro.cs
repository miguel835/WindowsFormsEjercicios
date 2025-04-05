using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        //Propiedades
        public string nombreLibro { get; set; }
        public string autorLibro { get; set; }
        public string editorialLibro { get; set;}
        public string añoPublicacionLibro { get; set; }
        //Constructor
        public Libro(string nombre, string autor, string editorial, string año)
        {
            this.nombreLibro = nombre;
            this.autorLibro = autor;
            this.editorialLibro = editorial;
            this.añoPublicacionLibro = año;
        }
    }
}
