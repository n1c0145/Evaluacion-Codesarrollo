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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(275, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(275, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(297, 172);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(63, 19);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activar";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(229, 211);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(171, 30);
            txtDescripcion.TabIndex = 3;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.Location = new Point(210, 287);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(75, 23);
            btnNuevoAlumno.TabIndex = 4;
            btnNuevoAlumno.Text = "Guardar";
            btnNuevoAlumno.UseVisualStyleBackColor = true;
            btnNuevoAlumno.Click += btnNuevoAlumno_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAgregarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevoAlumno);
            Controls.Add(txtDescripcion);
            Controls.Add(chkActivo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormAgregarAlumno";
            Text = "FormAgregarAlumno";
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
    }
}