using Sistema_de_Autobuses;
using SistemaAutobuses.CapaDatos;

namespace SistemaAutobuses.CapaNegocio
{
    public class usuarioBL
    {
        UsuarioDAO dao = new UsuarioDAO();

        public  Usuario Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new Exception("Debe escribir el usuario.");

            if (string.IsNullOrWhiteSpace(clave))
                throw new Exception("Debe escribir la contraseña.");

            Usuario u = dao.Login(usuario, clave);

            if (u == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            return u;
        }
    }
}
