using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;

namespace Biblioteca.Capa_Datos
{
    class Metodo_Prestamo
    {
        public string idLibro { get; set; }
        public DateTime FechaP { get; set; }
        public DateTime FechaD { get; set;}
        public string anulado { get; set; }
        public int existencia { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }




    }
}
