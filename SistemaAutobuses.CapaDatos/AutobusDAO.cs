using Microsoft.Data.SqlClient;
using Sistema_de_Autobuses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaDatos
{
    public class AutobusDAO
    {
        SqlConnection cn = Conexion.Instancia.CrearConexion();

        public void Insertar(Autobus a)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarAutobus", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Marca", a.Marca);
            cmd.Parameters.AddWithValue("@Modelo", a.Modelo);
            cmd.Parameters.AddWithValue("@Placa", a.Placa);
            cmd.Parameters.AddWithValue("@Color", a.Color);
            cmd.Parameters.AddWithValue("@Anio", a.Anio);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Modificar(Autobus a)
        {
            SqlCommand cmd = new SqlCommand("sp_ModificarAutobus", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdAutobus", a.IdAutobus);
            cmd.Parameters.AddWithValue("@Marca", a.Marca);
            cmd.Parameters.AddWithValue("@Modelo", a.Modelo);
            cmd.Parameters.AddWithValue("@Placa", a.Placa);
            cmd.Parameters.AddWithValue("@Color", a.Color);
            cmd.Parameters.AddWithValue("@Anio", a.Anio);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Eliminar(int idAutobus)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarAutobus", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdAutobus", idAutobus);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListarAutobuses", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(tabla);

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_BuscarAutobus", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Texto", texto);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public DataTable Disponibles()
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("sp_AutobusesDisponibles", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(tabla);

            return tabla;
        }
    }
}
