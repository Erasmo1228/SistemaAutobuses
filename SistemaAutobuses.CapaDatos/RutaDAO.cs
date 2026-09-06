using Microsoft.Data.SqlClient;
using Sistema_de_Autobuses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaDatos
{
    public class RutaDAO
    {
        SqlConnection cn = Conexion.Instancia.CrearConexion();

        public void Insertar(Ruta r)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarRuta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreRuta", r.NombreRuta);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Modificar(Ruta r)
        {
            SqlCommand cmd = new SqlCommand("sp_ModificarRuta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdRuta", r.IdRuta);
            cmd.Parameters.AddWithValue("@NombreRuta", r.NombreRuta);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarRuta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdRuta", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListarRutas", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(tabla);

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_BuscarRuta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Texto", texto);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public DataTable Disponibles()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_RutasDisponibles", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(tabla);

            return tabla;
        }
    }
}
