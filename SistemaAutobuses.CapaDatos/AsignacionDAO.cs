using Microsoft.Data.SqlClient;
using Sistema_de_Autobuses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaDatos
{
    public class AsignacionDAO
    {
        SqlConnection cn = Conexion.Instancia.CrearConexion();

        public void Insertar(Asignacion a)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarAsignacion", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdChofer", a.IdChofer);
            cmd.Parameters.AddWithValue("@IdAutobus", a.IdAutobus);
            cmd.Parameters.AddWithValue("@IdRuta", a.IdRuta);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Finalizar(int idAsignacion)
        {
            SqlCommand cmd = new SqlCommand("sp_FinalizarAsignacion", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdAsignacion", idAsignacion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListarAsignaciones", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(tabla);

            return tabla;
        }
    }
}
