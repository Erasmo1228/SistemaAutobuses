using Microsoft.Data.SqlClient;
using Sistema_de_Autobuses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaAutobuses.CapaDatos
{
    public class UsuarioDAO
    {
        public Usuario Login(string usuario, string clave)
        {
            Usuario u = null;

            SqlConnection cn = Conexion.Instancia.CrearConexion();

            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    u = new Usuario();

                    u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    u.NombreUsuario = dr["Usuario"].ToString();
                    u.Clave = dr["Clave"].ToString();
                    u.Rol = dr["Rol"].ToString();
                }

                dr.Close();
            }
            finally
            {
                cn.Close();
            }

            return u;
        }
    }
}
