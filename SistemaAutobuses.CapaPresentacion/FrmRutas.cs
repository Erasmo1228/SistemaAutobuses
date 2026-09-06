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
    public partial class FrmRutas : Form
    {
        private RutaBL rutaBL = new RutaBL();

        private int idRutaSeleccionada = 0;
        public FrmRutas()
        {
            InitializeComponent();
        }
        private void ConfigurarFormulario()
        {
            chkDisponible.Checked = true;
            chkEstado.Checked = true;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvRutas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRutas.MultiSelect = false;

            dgvRutas.ReadOnly = true;

            dgvRutas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================================
        // LISTAR RUTAS
        // ==========================================

        private void ListarRutas()
        {
            try
            {
                dgvRutas.DataSource = rutaBL.Listar();

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

        // ==========================================
        // CONFIGURAR COLUMNAS
        // ==========================================

        private void ConfigurarColumnas()
        {
            if (dgvRutas.Columns.Count == 0)
                return;

            if (dgvRutas.Columns.Contains("IdRuta"))
                dgvRutas.Columns["IdRuta"].HeaderText = "ID";

            if (dgvRutas.Columns.Contains("NombreRuta"))
                dgvRutas.Columns["NombreRuta"].HeaderText =
                    "Nombre de ruta";

            if (dgvRutas.Columns.Contains("Disponible"))
                dgvRutas.Columns["Disponible"].HeaderText =
                    "Disponible";

            if (dgvRutas.Columns.Contains("Estado"))
                dgvRutas.Columns["Estado"].HeaderText =
                    "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ruta ruta = new Ruta();

                ruta.NombreRuta =
                    txtNombreRuta.Text.Trim();

                ruta.Disponible = true;

                ruta.Estado =
                    chkDisponible.Checked;

                rutaBL.Insertar(ruta);

                MessageBox.Show(
                    "Ruta registrada correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarRutas();

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
                if (idRutaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una ruta.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Ruta ruta = new Ruta();

                ruta.IdRuta =
                    idRutaSeleccionada;

                ruta.NombreRuta =
                    txtNombreRuta.Text.Trim();

                ruta.Estado =
                    chkDisponible.Checked;

                rutaBL.Modificar(ruta);

                MessageBox.Show(
                    "Ruta modificada correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarRutas();

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
                if (idRutaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una ruta.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar esta ruta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                    return;

                rutaBL.Eliminar(
                    idRutaSeleccionada
                );

                MessageBox.Show(
                    "Ruta eliminada correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarRutas();

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

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvRutas.Rows[e.RowIndex];

                
                idRutaSeleccionada =
                    Convert.ToInt32(
                        fila.Cells["IdRuta"].Value
                    );
                txtIDRuta.Text = idRutaSeleccionada.ToString();


                txtNombreRuta.Text =
                    fila.Cells["NombreRuta"].Value.ToString();

               

                if (dgvRutas.Columns.Contains("Estado"))
                {
                    chkEstado.Checked =
                        Convert.ToBoolean(
                            fila.Cells["Estado"].Value
                        );
                }
                if (dgvRutas.Columns.Contains("Disponible"))
                {
                    chkDisponible.Checked =
                        Convert.ToBoolean(
                            fila.Cells["Disponible"].Value
                        );
                }

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRutas.DataSource =
                    rutaBL.Buscar(
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
             private void LimpiarFormulario()
        {
            idRutaSeleccionada = 0;

            txtNombreRuta.Clear();

            chkDisponible.Checked = true;

            chkEstado.Checked = true;

            txtNombreRuta.Focus();

            btnGuardar.Enabled = true;

            btnModificar.Enabled = false;

            btnEliminar.Enabled = false;

            dgvRutas.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

