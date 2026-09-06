using Sistema_de_Autobuses;
using SistemaAutobuses.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaNegocio
{
    public class ChoferBL
    {
        ChoferDAO dao = new ChoferDAO();

        public void Insertar(Chofer chofer)
        {
            if (string.IsNullOrWhiteSpace(chofer.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(chofer.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(chofer.Cedula))
                throw new Exception("La cédula es obligatoria.");
            int edad = DateTime.Today.Year - chofer.FechaNacimiento.Year;

            if (chofer.FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                throw new Exception("El chofer debe ser mayor de edad.");
            }

            dao.Insertar(chofer);
        }

        public void Modificar(Chofer chofer)
        {
            dao.Modificar(chofer);
        }

        public void Eliminar(int id)
        {
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
