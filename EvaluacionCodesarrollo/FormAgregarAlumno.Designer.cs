namespace EvaluacionCodesarrollo
{
    partial class FormAgregarAlumno
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            chkActivo = new CheckBox();
            txtDescripcion = new TextBox();
            btnNuevoAlumno = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(196, 136);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(196, 189);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(226, 23);
            txtApellido.TabIndex = 1;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkActivo.Location = new Point(196, 228);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(141, 25);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activar Alumno";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(196, 270);
            txtDescripcion.MaxLength = 300;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.BackColor = Color.ForestGreen;
            btnNuevoAlumno.FlatStyle = FlatStyle.Flat;
            btnNuevoAlumno.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAlumno.ForeColor = Color.White;
            btnNuevoAlumno.Location = new Point(128, 326);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(75, 23);
            btnNuevoAlumno.TabIndex = 4;
            btnNuevoAlumno.Text = "Guardar";
            btnNuevoAlumno.UseVisualStyleBackColor = false;
            btnNuevoAlumno.Click += btnNuevoAlumno_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(262, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(255, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(54, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(163, 25);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Nuevo Alumno";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(77, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(77, 187);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 21);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(74, 268);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 21);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripción:";
            // 
            // FormAgregarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(484, 361);
            Controls.Add(lblDescripcion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevoAlumno);
            Controls.Add(txtDescripcion);
            Controls.Add(chkActivo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            ForeColor = Color.Black;
            Name = "FormAgregarAlumno";
            Text = "FormAgregarAlumno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private CheckBox chkActivo;
        private TextBox txtDescripcion;
        private Button btnNuevoAlumno;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDescripcion;
    }
}