using System;
using System.Windows.Forms;
using Negocio;

namespace UI
{
    public partial class NuevoSocioForm : Form
    {
        private readonly Club _club;

        private int DNI => int.Parse(dniTextBox.Text);
        private string Nombre => nombreTextBox.Text;
        private string Apellido => apellidoTextBox.Text;


        public NuevoSocioForm(Club club)
        {
            InitializeComponent();
            CenterToParent();

            _club = club;
        }

        private void crearSocioButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido) ||
                string.IsNullOrWhiteSpace(dniTextBox.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _club.CrearSocio(new Socio(Nombre, Apellido, DNI));

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
