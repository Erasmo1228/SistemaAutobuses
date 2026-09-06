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
    public partial class FrmAutobuses : Form
    {
        private AutobusBL autobusBL = new AutobusBL();

        private int idAutobusSeleccionado = 0;
        public FrmAutobuses()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ListarAutobuses();
        }
        private void ConfigurarFormulario()
        {
            nudAnio.Minimum = 1980;
            nudAnio.Maximum = DateTime.Now.Year + 1;
            nudAnio.Value = DateTime.Now.Year;

            chkDisponible.Checked = true;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvAutobuses.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAutobuses.MultiSelect = false;

            dgvAutobuses.ReadOnly = true;

            dgvAutobuses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LimpiarFormulario()
        {
            idAutobusSeleccionado = 0;

            txtMarca.Clear();

            txtModelo.Clear();

            txtPlaca.Clear();

            txtColor.Clear();

            nudAnio.Value =
                DateTime.Now.Year;

            chkDisponible.Checked = true;

            txtMarca.Focus();

            btnGuardar.Enabled = true;

            btnModificar.Enabled = false;

            btnEliminar.Enabled = false;

            dgvAutobuses.ClearSelection();
        }

        // ==========================================
        // LISTAR
        // ==========================================

        private void ListarAutobuses()
        {
            try
            {
                dgvAutobuses.DataSource =
                    autobusBL.Listar();

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
            if (dgvAutobuses.Columns.Count == 0)
                return;

            if (dgvAutobuses.Columns.Contains("IdAutobus"))
                dgvAutobuses.Columns["IdAutobus"].HeaderText = "ID";

            if (dgvAutobuses.Columns.Contains("Marca"))
                dgvAutobuses.Columns["Marca"].HeaderText = "Marca";

            if (dgvAutobuses.Columns.Contains("Modelo"))
                dgvAutobuses.Columns["Modelo"].HeaderText = "Modelo";

            if (dgvAutobuses.Columns.Contains("Placa"))
                dgvAutobuses.Columns["Placa"].HeaderText = "Placa";

            if (dgvAutobuses.Columns.Contains("Color"))
                dgvAutobuses.Columns["Color"].HeaderText = "Color";

            if (dgvAutobuses.Columns.Contains("Anio"))
                dgvAutobuses.Columns["Anio"].HeaderText = "Año";

            if (dgvAutobuses.Columns.Contains("Disponible"))
                dgvAutobuses.Columns["Disponible"].HeaderText =
                    "Disponible";

            if (dgvAutobuses.Columns.Contains("Estado"))
                dgvAutobuses.Columns["Estado"].HeaderText =
                    "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Autobus autobus = new Autobus();

                autobus.Marca = txtMarca.Text.Trim();

                autobus.Modelo = txtModelo.Text.Trim();

                autobus.Placa = txtPlaca.Text.Trim().ToUpper();

                autobus.Color = txtColor.Text.Trim();

                autobus.Anio = Convert.ToInt32(nudAnio.Value);

                autobus.Disponible = true;

                autobus.Estado = chkDisponible.Checked;

                autobusBL.Insertar(autobus);

                MessageBox.Show(
                    "Autobús registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarAutobuses();

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
                if (idAutobusSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un autobús.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Autobus autobus = new Autobus();

                autobus.IdAutobus =
                    idAutobusSeleccionado;

                autobus.Marca =
                    txtMarca.Text.Trim();

                autobus.Modelo =
                    txtModelo.Text.Trim();

                autobus.Placa =
                    txtPlaca.Text.Trim().ToUpper();

                autobus.Color =
                    txtColor.Text.Trim();

                autobus.Anio =
                    Convert.ToInt32(nudAnio.Value);

                autobus.Estado =
                    chkDisponible.Checked;

                autobusBL.Modificar(autobus);

                MessageBox.Show(
                    "Autobús modificado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarAutobuses();

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
                if (idAutobusSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un autobús.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este autobús?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                    return;

                autobusBL.Eliminar(
                    idAutobusSeleccionado
                );

                MessageBox.Show(
                    "Autobús eliminado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ListarAutobuses();

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

        private void dgvAutobuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvAutobuses.Rows[e.RowIndex];

                idAutobusSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["IdAutobus"].Value
                    );

                txtMarca.Text =
                    fila.Cells["Marca"].Value.ToString();

                txtModelo.Text =
                    fila.Cells["Modelo"].Value.ToString();

                txtPlaca.Text =
                    fila.Cells["Placa"].Value.ToString();

                txtColor.Text =
                    fila.Cells["Color"].Value.ToString();

                nudAnio.Value =
                    Convert.ToDecimal(
                        fila.Cells["Anio"].Value
                    );

                if (dgvAutobuses.Columns.Contains("Estado"))
                {
                    chkDisponible.Checked =
                        Convert.ToBoolean(
                            fila.Cells["Estado"].Value
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAutobuses.DataSource =
                    autobusBL.Buscar(
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

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
