using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionComputador
{
    public class Computador
    {
        //Atributos 
        public string Marca;
        public string Modelo;
        public string OS;
        public string Precio;
        //Propiedades
        public Monitor monitor { get; set; }
        public MemoriaRam memoriaRam { get; set; }
        public DiscoDuro discoDuro { get; set; }
        public Procesador procesador { get; set; }

    }
}
