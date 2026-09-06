using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autobuses
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public string Rol { get; set; }

        public bool Estado { get; set; }
    }
}
