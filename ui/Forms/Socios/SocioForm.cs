using System;
using System.Windows.Forms;
using Negocio;
using Negocio.Modelos;
using UI.Enums;

namespace UI.Forms
{
    public partial class SocioForm : Form
    {
        private readonly Club _club;
        private readonly int _id;

        public SocioForm(Club club, Socio socio = null)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();


            if (socio == null) return;

            CurrentMode = FormMode.Edit;

            Text = "Editar Socio";

            _id = socio.ID;
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
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido) ||
                    string.IsNullOrWhiteSpace(DNI))
                {
                    throw new Exception("Debe completar todos los campos");
                }

                var dni = Validator.ValidateDNI(DNI);

                var cuotaSocial = Validator.ValidateCuotaSocial(CuotaSocial);
                    
                if (CurrentMode == FormMode.Create)
                {
                    _club.CrearSocio(dni, Nombre, Apellido, cuotaSocial);

                    MessageBox.Show("Socio creado correctamente", "Socio Creado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    _club.EditarSocio(_id, dni, Nombre, Apellido, cuotaSocial);

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