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
            Alumno alumno = new Alumno
            {
                Identificador = alumnos.Max(x => x.Identificador) + 1,
                Nombre = txtNombre.Text + " " + txtApellido.Text,
                Activo = chkActivo.Checked,
                Descripcion = txtDescripcion.Text
            };

            alumnos.Add(alumno);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
