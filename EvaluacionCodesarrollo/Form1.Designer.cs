namespace EvaluacionCodesarrollo
{
    partial class Form1
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
            btnOrdenar = new Button();
            dgvAlumnos = new DataGridView();
            lstDisponibles = new ListBox();
            cmbSeleccionados = new ComboBox();
            txtDescripcion = new TextBox();
            btnOrdenarDesc = new Button();
            btnNuevoAlumno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(12, 38);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(107, 38);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(381, 269);
            dgvAlumnos.TabIndex = 1;
            // 
            // lstDisponibles
            // 
            lstDisponibles.FormattingEnabled = true;
            lstDisponibles.Location = new Point(607, 53);
            lstDisponibles.Name = "lstDisponibles";
            lstDisponibles.Size = new Size(120, 94);
            lstDisponibles.TabIndex = 2;
            lstDisponibles.DoubleClick += lstDisponibles_DoubleClick;
            // 
            // cmbSeleccionados
            // 
            cmbSeleccionados.FormattingEnabled = true;
            cmbSeleccionados.Location = new Point(532, 273);
            cmbSeleccionados.Name = "cmbSeleccionados";
            cmbSeleccionados.Size = new Size(234, 23);
            cmbSeleccionados.TabIndex = 3;
            cmbSeleccionados.SelectedIndexChanged += cmbSeleccionados_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(688, 177);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // btnOrdenarDesc
            // 
            btnOrdenarDesc.Location = new Point(12, 79);
            btnOrdenarDesc.Name = "btnOrdenarDesc";
            btnOrdenarDesc.Size = new Size(75, 23);
            btnOrdenarDesc.TabIndex = 5;
            btnOrdenarDesc.Text = "Order";
            btnOrdenarDesc.UseVisualStyleBackColor = true;
            btnOrdenarDesc.Click += btnOrdenarDesc_Click;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.Location = new Point(511, 317);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(129, 23);
            btnNuevoAlumno.TabIndex = 6;
            btnNuevoAlumno.Text = "Nuevo Alumno";
            btnNuevoAlumno.UseVisualStyleBackColor = true;
            btnNuevoAlumno.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoAlumno);
            Controls.Add(btnOrdenarDesc);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbSeleccionados);
            Controls.Add(lstDisponibles);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnOrdenar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private DataGridView dgvAlumnos;
        private ListBox lstDisponibles;
        private ComboBox cmbSeleccionados;
        private TextBox txtDescripcion;
        private Button btnOrdenarDesc;
        private Button btnNuevoAlumno;
    }
}
