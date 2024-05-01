using System;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Enums;

namespace UI
{
    public partial class ProfesorForm : Form
    {
        private readonly Club _club;

        public ProfesorForm(Club club, Profesor profesor = null)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();

            if (profesor == null) return;

            CurrentMode = FormMode.Edit;

            Text = "Editar Profesor";

            dniTextBox.Text = profesor.DNI.ToString();
            nombreTextBox.Text = profesor.Nombre;
            apellidoTextBox.Text = profesor.Apellido;
            especialidadTextBox.Text = profesor.Especialidad;
        }

        private string DNI => dniTextBox.Text;
        private string Nombre => nombreTextBox.Text;
        private string Apellido => apellidoTextBox.Text;
        private string Especialidad => especialidadTextBox.Text;
        public FormMode CurrentMode { get; } = FormMode.Create;

        private void crearSocioButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido) ||
                string.IsNullOrWhiteSpace(DNI) || string.IsNullOrWhiteSpace(Especialidad))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DNI, out var dni))
            {
                MessageBox.Show("El DNI debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (CurrentMode == FormMode.Create)
                {
                    _club.CrearProfesor(dni, Nombre, Apellido, Especialidad);

                    MessageBox.Show("Profesor creado correctamente", "Socio Creado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    _club.EditarProfesor(dni, Nombre, Apellido, Especialidad);

                    MessageBox.Show("Profesor editado correctamente", "Socio Editado", MessageBoxButtons.OK,
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