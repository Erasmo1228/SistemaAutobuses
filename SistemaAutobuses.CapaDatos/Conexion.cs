using Microsoft.Data.SqlClient;

namespace SistemaAutobuses.CapaDatos
{
    public sealed class Conexion
    {
        private static readonly Lazy<Conexion> _instancia = new Lazy<Conexion>(() => new Conexion());
        private readonly string _cadenaConexion;

        private Conexion()
        {
            _cadenaConexion = @"Server=.;Database=SistemaAutobuses;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public static Conexion Instancia => _instancia.Value;

        
        public SqlConnection CrearConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
    }
