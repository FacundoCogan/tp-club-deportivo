using System;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Enums;

namespace UI.Forms
{
    public partial class ActividadForm : Form
    {
        private readonly Club _club;
        private readonly int _id;

        private ActividadForm(Club club, Actividad actividad = null)
        {
            _club = club;

            InitializeComponent();
            CenterToScreen();

            profesorComboBox.DataSource = _club.Profesores;
            profesorComboBox.DisplayMember = "NombreCompleto";

            if (actividad == null) return;

            CurrentMode = FormMode.Edit;
            Text = "Editar Actividad";
            _id = actividad.ID;
            nombreTextBox.Text = actividad.Nombre;
            descripcionTextBox.Text = actividad.Descripcion;
            diasHorariosTextBox.Text = actividad.DiasHorarios;
            costoTextBox.Text = actividad.Costo.ToString();
            cupoMaximoNumericUpDown.Value = actividad.CupoMaximo;
            profesorComboBox.SelectedItem = actividad.Profesor;
        }

        private string Nombre => nombreTextBox.Text;
        private string Descripcion => descripcionTextBox.Text;
        private string DiasHorarios => diasHorariosTextBox.Text;
        private string Costo => costoTextBox.Text;
        private int CupoMaximo => (int)cupoMaximoNumericUpDown.Value;
        private Profesor Profesor => (Profesor)profesorComboBox.SelectedItem;
        public FormMode CurrentMode { get; } = FormMode.Create;

        public static ActividadForm CreateActividadForm(Club club, Actividad actividad = null)
        {
            if (club.Profesores.Count != 0)
            {
                return new ActividadForm(club, actividad);
            }

            MessageBox.Show("No hay profesores disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return null;
        }

        private void buttCrearAct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripcion) ||
                    string.IsNullOrWhiteSpace(DiasHorarios) ||
                    string.IsNullOrWhiteSpace(Costo) ||
                    CupoMaximo == 0)
                {
                    throw new Exception("Debe completar todos los campos");
                }

                if (!decimal.TryParse(Costo, out var costo))
                {
                    throw new Exception("El costo debe ser un número");
                }

                if (CurrentMode == FormMode.Edit)
                {
                    _club.EditarActividad(_id, Nombre, Descripcion, DiasHorarios, costo, CupoMaximo, Profesor.ID);

                    MessageBox.Show("Actividad editada correctamente", "Actividad Editada", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    _club.AgregarActividad(Nombre, Descripcion, DiasHorarios, costo, CupoMaximo, Profesor.ID);

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