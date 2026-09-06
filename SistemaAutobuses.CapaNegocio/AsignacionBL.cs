using Sistema_de_Autobuses;
using SistemaAutobuses.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaNegocio
{
    public class AsignacionBL
    {
        AsignacionDAO dao = new AsignacionDAO();

        public void Insertar(Asignacion asignacion)
        {
            if (asignacion.IdChofer <= 0)
                throw new Exception("Debe seleccionar un chofer.");

            if (asignacion.IdAutobus <= 0)
                throw new Exception("Debe seleccionar un autobús.");

            if (asignacion.IdRuta <= 0)
                throw new Exception("Debe seleccionar una ruta.");

            dao.Insertar(asignacion);
        }

        public void Finalizar(int idAsignacion)
        {
            if (idAsignacion <= 0)
                throw new Exception("Seleccione una asignación.");

            dao.Finalizar(idAsignacion);
        }

        public DataTable Listar()
        {
            return dao.Listar();
        }
    }
}
