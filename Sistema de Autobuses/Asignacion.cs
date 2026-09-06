using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autobuses
{
    public class Asignacion
    {
        public int IdAsignacion { get; set; }

        public int IdChofer { get; set; }

        public int IdAutobus { get; set; }

        public int IdRuta { get; set; }

        public DateTime FechaAsignacion { get; set; }

        public bool Estado { get; set; }
    }
}
