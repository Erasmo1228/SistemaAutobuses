using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autobuses
{
    public class Autobus
    {
        public int IdAutobus { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public int Anio { get; set; }

        public bool Disponible { get; set; }

        public bool Estado { get; set; }
    }
}
