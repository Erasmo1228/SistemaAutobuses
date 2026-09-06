using Sistema_de_Autobuses;
using SistemaAutobuses.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaNegocio
{
    public class RutaBL
    {
        RutaDAO dao = new RutaDAO();

        public void Insertar(Ruta ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta.NombreRuta))
                throw new Exception("Debe escribir el nombre de la ruta.");

            if (ruta.NombreRuta.Length < 3)
                throw new Exception("El nombre de la ruta es demasiado corto.");

            dao.Insertar(ruta);
        }

        public void Modificar(Ruta ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta.NombreRuta))
                throw new Exception("Debe escribir el nombre de la ruta.");

            if (ruta.NombreRuta.Length < 3)
                throw new Exception("El nombre de la ruta es demasiado corto.");

            dao.Modificar(ruta);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception(
                    "Seleccione una ruta."
                );
            dao.Eliminar(id);
        }

        public DataTable Listar()
        {
            return dao.Listar();
        }

        public DataTable Buscar(string texto)
        {
            return dao.Buscar(texto);
        }

        public DataTable Disponibles()
        {
            return dao.Disponibles();
        }
    }
}
