namespace SistemaAutobuses.CapaPresentacion
{
    partial class FrmChoferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoferes));
            panel1 = new Panel();
            chkEstado = new CheckBox();
            label7 = new Label();
            button1 = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            txtCedula = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtIDChofer = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvChoferes = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoferes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(chkEstado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtIDChofer);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 445);
            panel1.TabIndex = 0;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(109, 277);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(15, 14);
            chkEstado.TabIndex = 22;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 276);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 20;
            label7.Text = "Disponible";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(357, 406);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 4;
            button1.Text = "       Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.AppWorkspace;
            btnLimpiar.Location = new Point(264, 406);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 32);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(183, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 32);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            btnModificar.Location = new Point(102, 406);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 32);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.Location = new Point(13, 406);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 32);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(162, 225);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(102, 181);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(102, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtIDChofer
            // 
            txtIDChofer.Location = new Point(116, 65);
            txtIDChofer.Name = "txtIDChofer";
            txtIDChofer.ReadOnly = true;
            txtIDChofer.Size = new Size(100, 23);
            txtIDChofer.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 231);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 189);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 145);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 111);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 68);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "ID del chofer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del Chofer";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(dgvChoferes);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(483, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 445);
            panel2.TabIndex = 1;
            // 
            // dgvChoferes
            // 
            dgvChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoferes.Location = new Point(9, 52);
            dgvChoferes.Name = "dgvChoferes";
            dgvChoferes.Size = new Size(509, 390);
            dgvChoferes.TabIndex = 3;
            dgvChoferes.CellContentClick += dgvChoferes_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Blue;
            btnBuscar.Location = new Point(443, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 37);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(71, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(366, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 26);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "Buscar";
            // 
            // FrmChoferes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1005, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmChoferes";
            Text = "Mantenimiento de Choferes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoferes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtCedula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtIDChofer;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Panel panel2;
        private DataGridView dgvChoferes;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label9;
        private Button button1;
        private CheckBox chkEstado;
        private Label label7;
    }
}