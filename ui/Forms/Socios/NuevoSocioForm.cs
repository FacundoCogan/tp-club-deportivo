using System;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Enums;

namespace UI
{
    public partial class NuevoSocioForm : Form
    {
        private readonly Club _club;

        public NuevoSocioForm(Club club, SocioClub socio = null)
        {
            InitializeComponent();
            CenterToParent();

            _club = club;

            if (socio == null) return;

            CurrentMode = FormMode.Edit;

            Text = "Editar Socio";

            dniTextBox.Text = socio.DNI.ToString();
            nombreTextBox.Text = socio.Nombre;
            apellidoTextBox.Text = socio.Apellido;
            cuotaSocialTextBox.Text = socio.CuotaSocial.ToString();
        }

        private string DNI => dniTextBox.Text;
        private string Nombre => nombreTextBox.Text;
        private string Apellido => apellidoTextBox.Text;
        private string CuotaSocial => cuotaSocialTextBox.Text;
        public FormMode CurrentMode { get; } = FormMode.Create;

        private void crearSocioButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido) ||
                string.IsNullOrWhiteSpace(DNI) || string.IsNullOrWhiteSpace(CuotaSocial))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DNI, out var dni))
            {
                MessageBox.Show("El DNI debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(CuotaSocial, out var cuotaSocial))
            {
                MessageBox.Show("La cuota social debe ser un número", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                if (CurrentMode == FormMode.Create)
                {
                    _club.CrearSocio(dni, Nombre, Apellido, cuotaSocial);

                    MessageBox.Show("Socio creado correctamente", "Socio Creado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    _club.EditarSocio(dni, Nombre, Apellido, cuotaSocial);

                    MessageBox.Show("Socio editado correctamente", "Socio Editado", MessageBoxButtons.OK,
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