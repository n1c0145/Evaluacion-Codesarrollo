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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblDisponibles = new Label();
            lblSleccionados = new Label();
            lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.RoyalBlue;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = SystemColors.Info;
            btnOrdenar.ImageAlign = ContentAlignment.MiddleRight;
            btnOrdenar.Location = new Point(7, 116);
            btnOrdenar.Margin = new Padding(0);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(108, 25);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar A-Z ⇅";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos.BackgroundColor = Color.CornflowerBlue;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.GridColor = Color.CornflowerBlue;
            dgvAlumnos.Location = new Point(124, 116);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(519, 265);
            dgvAlumnos.TabIndex = 1;
            // 
            // lstDisponibles
            // 
            lstDisponibles.FormattingEnabled = true;
            lstDisponibles.Location = new Point(672, 153);
            lstDisponibles.Name = "lstDisponibles";
            lstDisponibles.Size = new Size(187, 94);
            lstDisponibles.TabIndex = 2;
            lstDisponibles.DoubleClick += lstDisponibles_DoubleClick;
            // 
            // cmbSeleccionados
            // 
            cmbSeleccionados.FormattingEnabled = true;
            cmbSeleccionados.Location = new Point(649, 330);
            cmbSeleccionados.Name = "cmbSeleccionados";
            cmbSeleccionados.Size = new Size(221, 23);
            cmbSeleccionados.TabIndex = 3;
            cmbSeleccionados.SelectedIndexChanged += cmbSeleccionados_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(649, 397);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(221, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // btnOrdenarDesc
            // 
            btnOrdenarDesc.BackColor = Color.RoyalBlue;
            btnOrdenarDesc.FlatStyle = FlatStyle.Flat;
            btnOrdenarDesc.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenarDesc.ForeColor = SystemColors.Info;
            btnOrdenarDesc.Location = new Point(7, 153);
            btnOrdenarDesc.Name = "btnOrdenarDesc";
            btnOrdenarDesc.Size = new Size(108, 23);
            btnOrdenarDesc.TabIndex = 5;
            btnOrdenarDesc.Text = "Ordenar Z-A ⇅";
            btnOrdenarDesc.UseVisualStyleBackColor = false;
            btnOrdenarDesc.Click += btnOrdenarDesc_Click;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.BackColor = Color.ForestGreen;
            btnNuevoAlumno.FlatStyle = FlatStyle.Flat;
            btnNuevoAlumno.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAlumno.ForeColor = SystemColors.Info;
            btnNuevoAlumno.Location = new Point(514, 87);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(129, 23);
            btnNuevoAlumno.TabIndex = 6;
            btnNuevoAlumno.Text = "+ Nuevo Alumno";
            btnNuevoAlumno.UseVisualStyleBackColor = false;
            btnNuevoAlumno.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(649, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(29, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(604, 29);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Evaluación Analista de Aplicaciones Eduardo Loza";
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisponibles.Location = new Point(686, 129);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(163, 21);
            lblDisponibles.TabIndex = 9;
            lblDisponibles.Text = "Alumnos Disponibles";
            // 
            // lblSleccionados
            // 
            lblSleccionados.AutoSize = true;
            lblSleccionados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSleccionados.Location = new Point(676, 306);
            lblSleccionados.Name = "lblSleccionados";
            lblSleccionados.Size = new Size(183, 21);
            lblSleccionados.TabIndex = 10;
            lblSleccionados.Text = "Alumnos Seleccionados";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(715, 373);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 21);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(884, 461);
            Controls.Add(lblDescripcion);
            Controls.Add(lblSleccionados);
            Controls.Add(lblDisponibles);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblDisponibles;
        private Label lblSleccionados;
        private Label lblDescripcion;
    }
}
