namespace SistemaAutobuses.CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkMostrarClave = new CheckBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIniciarSesion = new Button();
            btnSalir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 65);
            label1.Name = "label1";
            label1.Size = new Size(333, 30);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Gestion de Autobuses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 242);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 296);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // chkMostrarClave
            // 
            chkMostrarClave.AutoSize = true;
            chkMostrarClave.Location = new Point(320, 327);
            chkMostrarClave.Name = "chkMostrarClave";
            chkMostrarClave.Size = new Size(15, 14);
            chkMostrarClave.TabIndex = 4;
            chkMostrarClave.UseVisualStyleBackColor = true;
            chkMostrarClave.CheckedChanged += chkMostrarClave_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 326);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 5;
            label4.Text = "Mostrar Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(320, 243);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(127, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(320, 293);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(127, 23);
            txtClave.TabIndex = 7;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(227, 357);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(127, 23);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(378, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 109);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(159, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 54);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(330, 179);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 12;
            label5.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(647, 504);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(chkMostrarClave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkMostrarClave;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIniciarSesion;
        private Button btnSalir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
    }
}
