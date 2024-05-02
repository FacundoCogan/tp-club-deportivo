using System;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Enums;

namespace UI
{
    public partial class ActividadForm : Form
    {
        private readonly Club _club;
        private readonly int _id;

        public ActividadForm(Club club, Actividad actividad = null)
        {
            _club = club;


            InitializeComponent();
            CenterToScreen();

            if (actividad != null)
            {
                CurrentMode = FormMode.Edit;
                Text = "Editar Actividad";
                buttCrearAct.Text = "Editar";
                _id = actividad.ID;
                nombreTextBox.Text = actividad.Nombre;
                descripcionTextBox.Text = actividad.Descripcion;
                diasHorariosTextBox.Text = actividad.DiasHorarios;
                costoTextBox.Text = actividad.Costo.ToString();
                cupoMaximoNumericUpDown.Value = actividad.CupoMaximo;
                profesorComboBox.SelectedItem = actividad.Profesor;
            }
            profesorComboBox.DataSource = _club.Profesores;
            profesorComboBox.DisplayMember = "NombreCompleto";
        }

        private string Nombre => nombreTextBox.Text;
        private string Descripcion => descripcionTextBox.Text;
        private string DiasHorarios => diasHorariosTextBox.Text;
        private string Costo => costoTextBox.Text;
        private int CupoMaximo => (int)cupoMaximoNumericUpDown.Value;
        private Profesor Profesor => (Profesor)profesorComboBox.SelectedItem;
        public FormMode CurrentMode { get; } = FormMode.Create;

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
                if(CurrentMode == FormMode.Edit)
                {
                    _club.EditarActividad(_id, Nombre, Descripcion, DiasHorarios, costo, CupoMaximo, Profesor.DNI);

                    MessageBox.Show("Actividad editada correctamente", "Actividad Editada", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                }
                else
                {
                    _club.AgregarActividad(Nombre, Descripcion, DiasHorarios, costo, CupoMaximo, Profesor.DNI);

                    MessageBox.Show("Actividad creada correctamente", "Actividad Creada", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                }

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