namespace SistemaAutobuses.CapaPresentacion
{
    partial class FrmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutas));
            panel1 = new Panel();
            chkEstado = new CheckBox();
            label5 = new Label();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            chkDisponible = new CheckBox();
            txtNombreRuta = new TextBox();
            txtIDRuta = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvRutas = new DataGridView();
            button1 = new Button();
            txtBuscar = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(chkEstado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(chkDisponible);
            panel1.Controls.Add(txtNombreRuta);
            panel1.Controls.Add(txtIDRuta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 449);
            panel1.TabIndex = 0;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(105, 184);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(15, 14);
            chkEstado.TabIndex = 15;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 183);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 14;
            label5.Text = "Estado";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(348, 410);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(84, 33);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button5_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(267, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 33);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(186, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 33);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            btnModificar.Location = new Point(105, 410);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 33);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.Location = new Point(24, 410);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 33);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(116, 150);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(15, 14);
            chkDisponible.TabIndex = 7;
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.Location = new Point(131, 97);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(100, 23);
            txtNombreRuta.TabIndex = 6;
            // 
            // txtIDRuta
            // 
            txtIDRuta.Location = new Point(125, 60);
            txtIDRuta.Name = "txtIDRuta";
            txtIDRuta.ReadOnly = true;
            txtIDRuta.Size = new Size(100, 23);
            txtIDRuta.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 149);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Disponible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 100);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Ruta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "ID de ruta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 17);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos de la Ruta";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(dgvRutas);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(472, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 449);
            panel2.TabIndex = 1;
            // 
            // dgvRutas
            // 
            dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutas.Location = new Point(9, 43);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.Size = new Size(442, 400);
            dgvRutas.TabIndex = 3;
            dgvRutas.CellContentClick += dgvRutas_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(367, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(75, 14);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(284, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 14);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 0;
            label6.Text = "Buscar";
            // 
            // FrmRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmRutas";
            Text = "Mantenimiento Rutas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private CheckBox chkDisponible;
        private TextBox txtNombreRuta;
        private TextBox txtIDRuta;
        private Panel panel2;
        private DataGridView dgvRutas;
        private Button button1;
        private TextBox txtBuscar;
        private Label label6;
        private CheckBox chkEstado;
        private Label label5;
    }
}