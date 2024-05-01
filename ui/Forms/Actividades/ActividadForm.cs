using System;
using System.Windows.Forms;
using Negocio.Modelos;

namespace UI
{
    public partial class ActividadForm : Form
    {
        private readonly Club _club;

        public ActividadForm(Club club)
        {
            _club = club;


            InitializeComponent();
            CenterToScreen();

            profesorComboBox.DataSource = _club.Profesores;
            profesorComboBox.DisplayMember = "NombreCompleto";
        }

        private string Nombre => nombreTextBox.Text;
        private string Descripcion => descripcionTextBox.Text;
        private string DiasHorarios => diasHorariosTextBox.Text;
        private string Costo => costoTextBox.Text;
        private int CupoMaximo => (int)cupoMaximoNumericUpDown.Value;
        private Profesor Profesor => (Profesor)profesorComboBox.SelectedItem;

        private void buttCrearAct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripcion) ||
                string.IsNullOrWhiteSpace(DiasHorarios) ||
                string.IsNullOrWhiteSpace(Costo) ||
                CupoMaximo == 0)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Costo, out var costo))
            {
                MessageBox.Show("El costo debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _club.AgregarActividad(Nombre, Descripcion, DiasHorarios, costo, CupoMaximo, Profesor.DNI);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}