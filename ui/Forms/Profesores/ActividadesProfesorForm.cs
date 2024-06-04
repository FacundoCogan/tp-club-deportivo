using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ActividadesProfesorForm : Form
    {
        private readonly Club _club;
        private readonly Profesor _profesor;
        private FilterableDataGridView<Actividad> _filterableDataGridView;

        public ActividadesProfesorForm(Club club, Profesor profesor)
        {
            _club = club;
            _profesor = profesor;

            InitializeComponent();
            CenterToParent();
            SetupControls();
        }

        private void SetupControls()
        {
            _filterableDataGridView = new FilterableDataGridView<Actividad>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.ConsultarActividadesProfesor(_profesor.ID),
                DisplayProperties = new List<string> { "ID", "Nombre", "Descripcion", "DiasHorarios", "CupoMaximo" }
            };

            Controls.Add(_filterableDataGridView);
        }
    }
}