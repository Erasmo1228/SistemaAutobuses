using Sistema_de_Autobuses;
using SistemaAutobuses.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAutobuses.CapaPresentacion
{
    public partial class FrmChoferes : Form
    {
        private ChoferBL ChoferBL = new ChoferBL();
        private int idChoferSeleccionado = 0;
        public FrmChoferes()
        {
            InitializeComponent();
        }
        private void ConfigurarFormulario()
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvChoferes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvChoferes.MultiSelect = false;

            dgvChoferes.ReadOnly = true;

            dgvChoferes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ListarChoferes()
        {
            try
            {

                dgvChoferes.DataSource = ChoferBL.Listar();

                ConfigurarColumnas();
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
        private void ConfigurarColumnas()
        {
            if (dgvChoferes.Columns.Count == 0)
                return;

            if (dgvChoferes.Columns.Contains("IdChofer"))
                dgvChoferes.Columns["IdChofer"].HeaderText = "ID";

            if (dgvChoferes.Columns.Contains("Nombre"))
                dgvChoferes.Columns["Nombre"].HeaderText = "Nombre";

            if (dgvChoferes.Columns.Contains("Apellido"))
                dgvChoferes.Columns["Apellido"].HeaderText = "Apellido";

            if (dgvChoferes.Columns.Contains("Cedula"))
                dgvChoferes.Columns["Cedula"].HeaderText = "Cédula";

            if (dgvChoferes.Columns.Contains("FechaNacimiento"))
                dgvChoferes.Columns["FechaNacimiento"].HeaderText =
                    "Fecha de nacimiento";

            if (dgvChoferes.Columns.Contains("Disponible"))
                dgvChoferes.Columns["Disponible"].HeaderText =
                    "Disponible";

            if (dgvChoferes.Columns.Contains("Estado"))
                dgvChoferes.Columns["Estado"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Chofer chofer = new Chofer();

                chofer.Nombre = txtNombre.Text.Trim();

                chofer.Apellido = txtApellido.Text.Trim();

                chofer.Cedula = txtCedula.Text.Trim();

                chofer.FechaNacimiento =
                    dtpFechaNacimiento.Value.Date;

                chofer.Disponible = true;

                chofer.Estado = true;

                ChoferBL.Insertar(chofer);

                MessageBox.Show(
                    "Chofer registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarChoferes();

                LimpiarFormulario();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idChoferSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un chofer.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Chofer chofer = new Chofer();

                chofer.IdChofer = idChoferSeleccionado;

                chofer.Nombre = txtNombre.Text.Trim();

                chofer.Apellido = txtApellido.Text.Trim();

                chofer.Cedula = txtCedula.Text.Trim();

                chofer.FechaNacimiento =
                    dtpFechaNacimiento.Value.Date;

                ChoferBL.Modificar(chofer);

                MessageBox.Show(
                    "Chofer modificado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarChoferes();

                LimpiarFormulario();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idChoferSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un chofer.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este chofer?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                    return;

                ChoferBL.Eliminar(idChoferSeleccionado);

                MessageBox.Show(
                    "Chofer eliminado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarChoferes();

                LimpiarFormulario();
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvChoferes.DataSource =
                    ChoferBL.Buscar(
                        txtBuscar.Text.Trim()
                    );

                ConfigurarColumnas();
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
        private void LimpiarFormulario()
        {
            idChoferSeleccionado = 0;

            txtNombre.Clear();

            txtApellido.Clear();

            txtCedula.Clear();

            dtpFechaNacimiento.Value =
                DateTime.Today;

            txtNombre.Focus();

            btnGuardar.Enabled = true;

            btnModificar.Enabled = false;

            btnEliminar.Enabled = false;

            dgvChoferes.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvChoferes.Rows[e.RowIndex];

                idChoferSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["IdChofer"].Value
                    );

                txtNombre.Text =
                    fila.Cells["Nombre"].Value.ToString();

                txtApellido.Text =
                    fila.Cells["Apellido"].Value.ToString();

                txtCedula.Text =
                    fila.Cells["Cedula"].Value.ToString();

                dtpFechaNacimiento.Value =
                    Convert.ToDateTime(
                        fila.Cells["FechaNacimiento"].Value
                    );

                btnModificar.Enabled = true;

                btnEliminar.Enabled = true;

                btnGuardar.Enabled = false;
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
    }

}
