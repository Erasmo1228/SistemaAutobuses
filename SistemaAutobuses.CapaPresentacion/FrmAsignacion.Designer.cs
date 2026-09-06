namespace SistemaAutobuses.CapaPresentacion
{
    partial class FrmAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacion));
            panel1 = new Panel();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            btnFinalizar = new Button();
            btnGuardar = new Button();
            chkEstado = new CheckBox();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            cmbRuta = new ComboBox();
            label4 = new Label();
            cmbAutobus = new ComboBox();
            label3 = new Label();
            cmbChofer = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvAsignaciones = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnFinalizar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(chkEstado);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbRuta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbAutobus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbChofer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 448);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(272, 407);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(83, 33);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(187, 408);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 30);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.LightCoral;
            btnFinalizar.Location = new Point(102, 408);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(79, 33);
            btnFinalizar.TabIndex = 11;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.Location = new Point(22, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 33);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Asignar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(111, 274);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(59, 19);
            chkEstado.TabIndex = 9;
            chkEstado.Text = "Activa";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(104, 221);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 221);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "Fecha";
            // 
            // cmbRuta
            // 
            cmbRuta.FormattingEnabled = true;
            cmbRuta.Location = new Point(104, 167);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(121, 23);
            cmbRuta.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 170);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "Ruta";
            // 
            // cmbAutobus
            // 
            cmbAutobus.FormattingEnabled = true;
            cmbAutobus.Location = new Point(108, 122);
            cmbAutobus.Name = "cmbAutobus";
            cmbAutobus.Size = new Size(121, 23);
            cmbAutobus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 125);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Autobus";
            // 
            // cmbChofer
            // 
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(104, 67);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(121, 23);
            cmbChofer.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 67);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Chofer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Asignaciones";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAsignaciones);
            panel2.Location = new Point(442, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 448);
            panel2.TabIndex = 1;
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaciones.Location = new Point(3, 3);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.Size = new Size(534, 442);
            dgvAsignaciones.TabIndex = 0;
            dgvAsignaciones.CellContentClick += dgvAsignaciones_CellContentClick;
            // 
            // FrmAsignacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAsignacion";
            Text = "Mantenimiento Asignaciones";
            Load += FrmAsignacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbChofer;
        private Label label2;
        private Label label1;
        private CheckBox chkEstado;
        private DateTimePicker dtpFecha;
        private Label label5;
        private ComboBox cmbRuta;
        private Label label4;
        private ComboBox cmbAutobus;
        private Label label3;
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnFinalizar;
        private Button btnGuardar;
        private Panel panel2;
        private DataGridView dgvAsignaciones;
    }
}