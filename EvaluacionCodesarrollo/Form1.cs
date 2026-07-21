namespace EvaluacionCodesarrollo
{
    public partial class Form1 : Form
    {

        List<Alumno> alumnos = new List<Alumno>();
        List<Alumno> disponibles = new List<Alumno>();
        List<Alumno> seleccionados = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            alumnos.Add(new Alumno
            {
                Identificador = 1,
                Nombre = "Marco Pérez",
                Activo = true,
                Descripcion = "Alumno con excelentes calificaciones"
            });

            alumnos.Add(new Alumno
            {
                Identificador = 2,
                Nombre = "Pilar Toapanta",
                Activo = false,
                Descripcion = "Alumno ha desertado en múltiples ocasiones"
            });

            alumnos.Add(new Alumno
            {
                Identificador = 3,
                Nombre = "Adrián Almeida",
                Activo = true,
                Descripcion = "Alumno promedio, proceso aprendizaje"
            });

            alumnos.Add(new Alumno
            {
                Identificador = 4,
                Nombre = "Marcela Pazmiño",
                Activo = true,
                Descripcion = "Alumno regular, requiere refuerzo"
            });

            alumnos.Add(new Alumno
            {
                Identificador = 5,
                Nombre = "Arturo Ureña",
                Activo = true,
                Descripcion = "Alumno regular, ha desertado en 2 ocasiones"
            });

            alumnos.Add(new Alumno
            {
                Identificador = 6,
                Nombre = "Lina Cachago",
                Activo = false,
                Descripcion = "Alumno no asiste desde segunda clase"
            });
            alumnos.Add(new Alumno
            {
                Identificador = 7,
                Nombre = "Diego Cazares",
                Activo = true,
                Descripcion = "Alumno con excelentes calificaciones"
            });
            alumnos.Add(new Alumno
            {
                Identificador = 8,
                Nombre = "Andrea Perez",
                Activo = true,
                Descripcion = "Alumno con excelentes calificaciones"
            });
            alumnos.Add(new Alumno
            {
                Identificador = 9,
                Nombre = "Kevin Zambrano",
                Activo = false,
                Descripcion = "El alumnos nunca asistió"
            });
            alumnos.Add(new Alumno
            {
                Identificador = 10,
                Nombre = "Carlos Nuñez",
                Activo = true,
                Descripcion = "Alumno con excelentes calificaciones"
            });
            alumnos.Add(new Alumno
            {
                Identificador = 11,
                Nombre = "Karla Travez",
                Activo = true,
                Descripcion = "Alumno con calificaciones aceptables"
            });
            dgvAlumnos.DataSource = alumnos;
            dgvAlumnos.Columns["Identificador"].HeaderText = "Código";
            dgvAlumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvAlumnos.Columns["Activo"].HeaderText = "Activo";
            dgvAlumnos.Columns["Descripcion"].HeaderText = "Descripción";
            disponibles = alumnos
                 .Where(x => x.Activo == true)
                 .ToList();
            lstDisponibles.DataSource = disponibles;
            lstDisponibles.DisplayMember = "Nombre";
        }

        private void lstDisponibles_DoubleClick(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = (Alumno)lstDisponibles.SelectedItem;

            Alumno? alumno = disponibles
            .FirstOrDefault(x => x.Identificador == alumnoSeleccionado.Identificador);

            if (alumno != null)
            {
                seleccionados.Add(alumno);

                disponibles.Remove(alumno);

                lstDisponibles.DataSource = null;
                lstDisponibles.DataSource = disponibles;
                lstDisponibles.DisplayMember = "Nombre";


                cmbSeleccionados.DataSource = null;
                cmbSeleccionados.DataSource = seleccionados;
                cmbSeleccionados.DisplayMember = "Nombre";
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            alumnos = alumnos
                .OrderBy(x => x.Nombre)
                .ToList();

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos;
        }

        private void btnOrdenarDesc_Click(object sender, EventArgs e)
        {
            alumnos = alumnos
            .OrderByDescending(x => x.Nombre)
            .ToList();

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos;
        }

        private void cmbSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alumno? alumno = cmbSeleccionados.SelectedItem as Alumno;

            if (alumno != null)
            {
                txtDescripcion.Text = alumno.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno formulario = new FormAgregarAlumno(alumnos);

            formulario.ShowDialog();

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos;

            disponibles = alumnos
                .Where(x => x.Activo == true)
                .ToList();

            lstDisponibles.DataSource = null;
            lstDisponibles.DataSource = disponibles;
            lstDisponibles.DisplayMember = "Nombre";
        }
    }
}
