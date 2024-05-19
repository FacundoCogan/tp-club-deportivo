using System;
using System.Windows.Forms;
using Negocio.Modelos;

namespace UI.Forms
{
    public partial class InscribirSocioActividadForm : Form
    {
        private readonly Club _club;
        private readonly Socio _socio;

        public InscribirSocioActividadForm(Club club, Socio socio)
        {
            _club = club;
            _socio = socio;

            InitializeComponent();
            CenterToParent();

            actividadesComboBox.DataSource = _club.GetActividadesDisponiblesSocio(_socio.ID);
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var actividad = (Actividad)actividadesComboBox.SelectedItem;

                if (MessageBox.Show(
                        $"¿Está seguro que desea inscribir al socio {_socio.NombreCompleto} en la actividad {actividad.Nombre}?",
                        "Confirmar inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes)
                {
                    return;
                }

                _club.InscribirSocioActividad(_socio.ID, actividad.ID);

                MessageBox.Show("Socio inscripto correctamente", "Socio inscripto", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch
            {
                MessageBox.Show("No se pudo inscribir al socio en la actividad", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}