using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using Sistema_de_Autobuses;

namespace SistemaAutobuses.CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            ConfigurarPermisos();
            MostrarUsuario();

        }
        private void AbrirFormulario(Form formulario)
        {
            formulario.ShowDialog();
            formulario.Dispose();
        }
        private void ConfigurarPermisos()
        {
            if (Sesion.Rol == "Administrador")
            {
                btnChoferes.Visible = true;
                btnAutobuses.Visible = true;
                btnRutas.Visible = true;
                btnAsignaciones.Visible = true;
            }
            else
            {
                btnChoferes.Visible = false;
                btnAutobuses.Visible = false;
                btnRutas.Visible = false;
                btnAsignaciones.Visible = true;
            }
        }
        private void MostrarUsuario()
        {
            lblUsuario.Text = Sesion.Usuario;
            lblRol.Text = "Rol: " + Sesion.Rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Desea cerrar sesión?",
        "Cerrar sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (resultado == DialogResult.Yes)
            {
                Sesion.IdUsuario = 0;
                Sesion.Usuario = "";
                Sesion.Rol = "";

                this.Hide();

                Login login = new Login();
                login.Show();
            }
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmChoferes());
        }

        private void btnAutobuses_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutobuses());
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRutas());
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAsignacion());
        }
    }
}
