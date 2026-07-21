using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace EvaluacionCodesarrollo
{
    public partial class FormAgregarAlumno : Form
    {
        private List<Alumno> alumnos;
        public FormAgregarAlumno(List<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show(
                    "Por favor complete todos los campos obligatorios",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;

            Alumno alumno = new Alumno
            {
                Identificador = alumnos.Max(x => x.Identificador) + 1,
                Nombre = nombreCompleto,
                Activo = chkActivo.Checked,
                Descripcion = txtDescripcion.Text
            };

            alumnos.Add(alumno);

            MessageBox.Show(
                $"El alumno {nombreCompleto} fue creado con éxito",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
