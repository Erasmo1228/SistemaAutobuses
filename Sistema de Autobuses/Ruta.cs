using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autobuses
{
    public class Ruta
    {
        public int IdRuta { get; set; }

        public string NombreRuta { get; set; }

        public bool Disponible { get; set; }

        public bool Estado { get; set; }
    }
}
