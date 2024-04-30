using System;
using System.Windows.Forms;
using Negocio.Modelos;

namespace UI
{
    public partial class ActivForm : Form
    {
        private readonly Club _club;

        private string nombre => nombreTextBox.Text.ToLower();
        private string descripcion => descripcionTextBox.Text;
        private string diasHorarios => diasHorariosTextBox.Text;
        private double costo => double.Parse(costoTextBox.Text);
        private int cupoMaximo => int.Parse(cupoMaximoTextBox.Text);
        //private Profesor profesor => (Profesor)profesorComboBox.SelectedItem;

        public ActivForm(Club club)
        {
            InitializeComponent();
            CenterToScreen();

            _club = club;
        }

        private void buttCrearAct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(diasHorarios) ||
                string.IsNullOrWhiteSpace(costoTextBox.Text) || string.IsNullOrWhiteSpace(cupoMaximoTextBox.Text) /*|| profesorComboBox.SelectedItem == null*/)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //_club.AgregarActividad(new Actividad(nombre, descripcion, diasHorarios, costo, cupoMaximo /*profesor*/));

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
