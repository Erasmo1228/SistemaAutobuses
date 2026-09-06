namespace SistemaAutobuses.CapaPresentacion
{
    partial class FrmAutobuses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutobuses));
            panel1 = new Panel();
            label9 = new Label();
            button5 = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            chkDisponible = new CheckBox();
            nudAnio = new NumericUpDown();
            txtColor = new TextBox();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvAutobuses = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            chkEstado = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(chkEstado);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(chkDisponible);
            panel1.Controls.Add(nudAnio);
            panel1.Controls.Add(txtColor);
            panel1.Controls.Add(txtPlaca);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 447);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 274);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 19;
            label9.Text = "Disponible";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(326, 403);
            button5.Name = "button5";
            button5.Size = new Size(84, 34);
            button5.TabIndex = 18;
            button5.Text = "Cerrar";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlLight;
            btnLimpiar.Location = new Point(246, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 34);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(165, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            btnModificar.Location = new Point(84, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 34);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 192);
            btnGuardar.Location = new Point(3, 403);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 34);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(104, 278);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(15, 14);
            chkDisponible.TabIndex = 13;
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(104, 230);
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(120, 23);
            nudAnio.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(104, 192);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 11;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(104, 157);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(104, 116);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(104, 75);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 308);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 232);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 192);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 157);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 116);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 74);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 0;
            label1.Text = "Datos del Autobus";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(dgvAutobuses);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(411, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 447);
            panel2.TabIndex = 1;
            // 
            // dgvAutobuses
            // 
            dgvAutobuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutobuses.Location = new Point(6, 57);
            dgvAutobuses.Name = "dgvAutobuses";
            dgvAutobuses.Size = new Size(519, 387);
            dgvAutobuses.TabIndex = 3;
            dgvAutobuses.CellContentClick += dgvAutobuses_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Cyan;
            btnBuscar.Location = new Point(424, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(86, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(323, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 20);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 0;
            label8.Text = "Buscar";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(92, 312);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(15, 14);
            chkEstado.TabIndex = 20;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // FrmAutobuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAutobuses";
            Text = "Mantenimiento de Autobuses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkDisponible;
        private NumericUpDown nudAnio;
        private TextBox txtColor;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label8;
        private Button button5;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvAutobuses;
        private Label label9;
        private CheckBox chkEstado;
    }
}