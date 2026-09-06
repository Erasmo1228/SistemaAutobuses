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
    public partial class FrmAsignacion : Form
    {
        private AsignacionBL asignacionBL = new AsignacionBL();

        private ChoferBL choferBL = new ChoferBL();

        private AutobusBL autobusBL = new AutobusBL();

        private RutaBL rutaBL = new RutaBL();

        private int idAsignacionSeleccionada = 0;
        public FrmAsignacion()
        {
            InitializeComponent();
            ConfigurarFormulario();

            CargarChoferesDisponibles();

            CargarAutobusesDisponibles();

            CargarRutasDisponibles();

            ListarAsignaciones();
        }
        private void ConfigurarFormulario()
        {
            dtpFecha.Value = DateTime.Today;

            chkEstado.Checked = true;

            cmbChofer.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbAutobus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRuta.DropDownStyle =
                ComboBoxStyle.DropDownList;

            btnFinalizar.Enabled = false;

            dgvAsignaciones.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAsignaciones.MultiSelect = false;

            dgvAsignaciones.ReadOnly = true;

            dgvAsignaciones.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarChoferesDisponibles()
        {
            try
            {
                DataTable datos =
                choferBL.Disponibles();

                cmbChofer.DataSource = datos;

                cmbChofer.DisplayMember = "NombreCompleto";

                cmbChofer.ValueMember = "IdChofer";

                cmbChofer.SelectedIndex = -1;
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
        private void CargarAutobusesDisponibles()
        {
            try
            {
                DataTable datos =
                    autobusBL.Disponibles();

                cmbAutobus.DataSource = datos;

                cmbAutobus.DisplayMember = "Autobus";

                cmbAutobus.ValueMember = "IdAutobus";

                cmbAutobus.SelectedIndex = -1;
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
        private void CargarRutasDisponibles()
        {
            try
            {
                DataTable datos =
                    rutaBL.Disponibles();

                cmbRuta.DataSource = datos;

                cmbRuta.DisplayMember = "NombreRuta";

                cmbRuta.ValueMember = "IdRuta";

                cmbRuta.SelectedIndex = -1;
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
        private void ListarAsignaciones()
        {
            try
            {
                dgvAsignaciones.DataSource =
                    asignacionBL.Listar();

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
            if (dgvAsignaciones.Columns.Count == 0)
                return;

            if (dgvAsignaciones.Columns.Contains("IdAsignacion"))
                dgvAsignaciones.Columns["IdAsignacion"].HeaderText =
                    "ID";

            if (dgvAsignaciones.Columns.Contains("Chofer"))
                dgvAsignaciones.Columns["Chofer"].HeaderText =
                    "Chofer";

            if (dgvAsignaciones.Columns.Contains("Autobus"))
                dgvAsignaciones.Columns["Autobus"].HeaderText =
                    "Autobús";

            if (dgvAsignaciones.Columns.Contains("Ruta"))
                dgvAsignaciones.Columns["Ruta"].HeaderText =
                    "Ruta";

            if (dgvAsignaciones.Columns.Contains("FechaAsignacion"))
                dgvAsignaciones.Columns["FechaAsignacion"].HeaderText =
                    "Fecha";

            if (dgvAsignaciones.Columns.Contains("Estado"))
                dgvAsignaciones.Columns["Estado"].HeaderText =
                    "Estado";
        }

        private void FrmAsignacion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbChofer.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un chofer.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (cmbAutobus.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un autobús.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (cmbRuta.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar una ruta.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Asignacion asignacion =
                    new Asignacion();

                asignacion.IdChofer =
                    Convert.ToInt32(
                        cmbChofer.SelectedValue
                    );

                asignacion.IdAutobus =
                    Convert.ToInt32(
                        cmbAutobus.SelectedValue
                    );

                asignacion.IdRuta =
                    Convert.ToInt32(
                        cmbRuta.SelectedValue
                    );

                asignacion.FechaAsignacion =
                    dtpFecha.Value.Date;

                asignacion.Estado =
                    chkEstado.Checked;

                asignacionBL.Insertar(asignacion);

                MessageBox.Show(
                    "Asignación realizada correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarAsignaciones();

                CargarCombos();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo realizar la asignación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAsignacionSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una asignación.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Desea Finalizar esta asignación?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultado == DialogResult.No)
                    return;

                asignacionBL.Finalizar(
                    idAsignacionSeleccionada
                );

                MessageBox.Show(
                    "Asignación Finalizada correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarAsignaciones();

                CargarCombos();

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

        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvAsignaciones.Rows[e.RowIndex];

                idAsignacionSeleccionada =
                    Convert.ToInt32(
                        fila.Cells["IdAsignacion"].Value
                    );

                btnFinalizar.Enabled = true;
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
        private void CargarCombos()
        {
            CargarChoferesDisponibles();

            CargarAutobusesDisponibles();

            CargarRutasDisponibles();
        }
        private void LimpiarFormulario()
        {
            idAsignacionSeleccionada = 0;

            cmbChofer.SelectedIndex = -1;

            cmbAutobus.SelectedIndex = -1;

            cmbRuta.SelectedIndex = -1;

            dtpFecha.Value = DateTime.Today;

            chkEstado.Checked = true;

            btnFinalizar.Enabled = false;

            dgvAsignaciones.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }

}
