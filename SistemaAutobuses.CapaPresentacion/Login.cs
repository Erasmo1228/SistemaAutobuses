using Sistema_de_Autobuses;
using SistemaAutobuses.CapaNegocio;

namespace SistemaAutobuses.CapaPresentacion
{
    public partial class Login : Form


    {
        private usuarioBL usuarioBL = new usuarioBL();
        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar el usuario.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar la contraseña.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtClave.Focus();
                    return;
                }

                // Obtener usuario desde la capa de negocio
                Usuario usuario = usuarioBL.Login(
                    txtUsuario.Text.Trim(),
                    txtClave.Text
                );

                // Verificar si existe
                if (usuario == null)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtClave.Clear();
                    txtClave.Focus();

                    return;
                }

                // Guardar información de la sesión
                Sesion.IdUsuario = usuario.IdUsuario;
                Sesion.Usuario = usuario.NombreUsuario;
                Sesion.Rol = usuario.Rol;

                // Abrir menú principal
                MenuPrincipal menu = new MenuPrincipal();

                menu.Show();

                // Ocultar Login
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void chkMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarClave.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        
    }
    }

}
