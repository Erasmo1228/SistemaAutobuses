namespace SistemaAutobuses.CapaPresentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btnChoferes = new Button();
            btnAutobuses = new Button();
            btnRutas = new Button();
            btnAsignaciones = new Button();
            lblNombreUsuario = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnChoferes
            // 
            btnChoferes.Image = (Image)resources.GetObject("btnChoferes.Image");
            btnChoferes.Location = new Point(185, 144);
            btnChoferes.Name = "btnChoferes";
            btnChoferes.Size = new Size(147, 135);
            btnChoferes.TabIndex = 0;
            btnChoferes.Text = "Choferes";
            btnChoferes.TextAlign = ContentAlignment.BottomCenter;
            btnChoferes.UseVisualStyleBackColor = true;
            btnChoferes.Click += btnChoferes_Click;
            // 
            // btnAutobuses
            // 
            btnAutobuses.Image = (Image)resources.GetObject("btnAutobuses.Image");
            btnAutobuses.Location = new Point(356, 144);
            btnAutobuses.Name = "btnAutobuses";
            btnAutobuses.Size = new Size(147, 135);
            btnAutobuses.TabIndex = 1;
            btnAutobuses.Text = "Autobuses";
            btnAutobuses.TextAlign = ContentAlignment.BottomCenter;
            btnAutobuses.UseVisualStyleBackColor = true;
            btnAutobuses.Click += btnAutobuses_Click;
            // 
            // btnRutas
            // 
            btnRutas.Image = (Image)resources.GetObject("btnRutas.Image");
            btnRutas.Location = new Point(530, 144);
            btnRutas.Name = "btnRutas";
            btnRutas.Size = new Size(147, 135);
            btnRutas.TabIndex = 2;
            btnRutas.Text = "Ruta";
            btnRutas.TextAlign = ContentAlignment.BottomCenter;
            btnRutas.UseVisualStyleBackColor = true;
            btnRutas.Click += btnRutas_Click;
            // 
            // btnAsignaciones
            // 
            btnAsignaciones.Image = (Image)resources.GetObject("btnAsignaciones.Image");
            btnAsignaciones.Location = new Point(708, 144);
            btnAsignaciones.Name = "btnAsignaciones";
            btnAsignaciones.Size = new Size(147, 135);
            btnAsignaciones.TabIndex = 3;
            btnAsignaciones.Text = "Asignaciones";
            btnAsignaciones.TextAlign = ContentAlignment.BottomCenter;
            btnAsignaciones.UseVisualStyleBackColor = true;
            btnAsignaciones.Click += btnAsignaciones_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(64, 29);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(0, 15);
            lblNombreUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(80, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = " Usuario ";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(11, 99);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(30, 15);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 100);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 28);
            button1.Name = "button1";
            button1.Size = new Size(157, 72);
            button1.TabIndex = 9;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(lblRol);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 391);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 230);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 11;
            label2.Text = "Gestion de autobuses";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(51, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 68);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 48);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(423, 32);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 9;
            label3.Text = "AutoZBus System";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(463, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 63);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(723, 57);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 10;
            label4.Text = "Developed by: Erasmo Ortega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 75);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 11;
            label5.Text = "@All rights reserved 2026";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(899, 491);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnAsignaciones);
            Controls.Add(btnRutas);
            Controls.Add(btnAutobuses);
            Controls.Add(btnChoferes);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChoferes;
        private Button btnAutobuses;
        private Button btnRutas;
        private Button btnAsignaciones;
        private Label lblNombreUsuario;
        private Label lblUsuario;
        private Label lblRol;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label4;
    }
}