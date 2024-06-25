using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class VerParticipantesActividadForm : Form
    {
        private readonly Actividad _actividad;
        private readonly Club _club;
        private FilterableDataGridView<Socio> _filterableDataGridView;

        public VerParticipantesActividadForm(Club club, Actividad actividad)
        {
            _club = club;
            _actividad = actividad;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView<Socio>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.GetParticipantesActividad(_actividad.ID),
                DisplayProperties = new List<string> { "ID", "DNI", "Nombre", "Apellido" }
            };

            Controls.Add(_filterableDataGridView);
        }
    }
}