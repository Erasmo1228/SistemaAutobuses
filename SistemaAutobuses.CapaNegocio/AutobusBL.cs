using Sistema_de_Autobuses;
using SistemaAutobuses.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaNegocio
{

    public class AutobusBL
    {
        AutobusDAO dao = new AutobusDAO();

        public void Insertar(Autobus autobus)
        {
            if (string.IsNullOrWhiteSpace(autobus.Marca))
                throw new Exception("La marca es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Modelo))
                throw new Exception("El modelo es obligatorio.");

            if (string.IsNullOrWhiteSpace(autobus.Placa))
                throw new Exception("La placa es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Color))
                throw new Exception("El color es obligatorio.");

            if (autobus.Anio < 1980 || autobus.Anio > DateTime.Now.Year + 1)
                throw new Exception("El año del autobús no es válido.");

            dao.Insertar(autobus);
        }

        public void Modificar(Autobus autobus)
        {

            if (autobus.IdAutobus <= 0)
                throw new Exception(
                    "Seleccione un autobús."
                );
            if (string.IsNullOrWhiteSpace(autobus.Marca))
                throw new Exception("La marca es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Modelo))
                throw new Exception("El modelo es obligatorio.");

            if (string.IsNullOrWhiteSpace(autobus.Placa))
                throw new Exception("La placa es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Color))
                throw new Exception("El color es obligatorio.");

            if (autobus.Anio < 1980 || autobus.Anio > DateTime.Now.Year + 1)
                throw new Exception("El año del autobús no es válido.");

            dao.Modificar(autobus);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception(
                    "Seleccione un autobús."
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
