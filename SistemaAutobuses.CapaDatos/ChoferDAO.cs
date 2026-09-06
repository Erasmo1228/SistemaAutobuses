using Microsoft.Data.SqlClient;
using Sistema_de_Autobuses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaDatos
{
    public class ChoferDAO
    {
        SqlConnection cn = Conexion.Instancia.CrearConexion();

        public void Insertar(Chofer c)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarChofer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", c.Cedula);
            cmd.Parameters.AddWithValue("@FechaNacimiento", c.FechaNacimiento);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Modificar(Chofer c)
        {
            SqlCommand cmd = new SqlCommand("sp_ModificarChofer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdChofer", c.IdChofer);
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@Cedula", c.Cedula);
            cmd.Parameters.AddWithValue("@FechaNacimiento", c.FechaNacimiento);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarChofer", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdChofer", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListarChoferes", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(tabla);

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_BuscarChofer", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Texto", texto);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
        public DataTable Disponibles()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.CrearConexion())
            {
                using (SqlCommand cmd = new SqlCommand(
                    "sp_ChoferesDisponibles", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
