using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ActividadesSocioForm : Form
    {
        private readonly Club _club;
        private readonly Socio _socio;
        private FilterableDataGridView<Actividad> _filterableDataGridView;

        public ActividadesSocioForm(Club club, Socio socio)
        {
            _club = club;
            _socio = socio;

            InitializeComponent();
            CenterToParent();
            SetupControls();
        }

        private void SetupControls()
        {
            _filterableDataGridView = new FilterableDataGridView<Actividad>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.ConsultarActividadesSocio(_socio.ID),
                DisplayProperties = new List<string> { "ID", "Nombre" }
            };

            _filterableDataGridView.AddDeleteButton(OnDeleteClicked, "Desinscribir");

            Controls.Add(_filterableDataGridView);
        }

        private void OnDeleteClicked(Actividad actividad)
        {
            try
            {
                if (MessageBox.Show(
                        $"¿Está seguro que desea desinscribir al socio {_socio.NombreCompleto} de la actividad {actividad.Nombre}?",
                        "Confirmar desinscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes)
                {
                    return;
                }

                _club.DarBajaSocioActividad(_socio.ID, actividad.ID);

                MessageBox.Show("Socio desinscripto correctamente", "Socio desinscripto", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se pudo desinscribir al socio de la actividad", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}