using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autobuses
{
    public class Chofer
    {
        public int IdChofer { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool Disponible { get; set; }

        public bool Estado { get; set; }
    }
}
