using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ActividadesForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView<Actividad> _filterableDataGridView;

        public ActividadesForm(Club club)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView<Actividad>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.Actividades,
                DisplayProperties = new List<string>
                    { "ID", "Nombre", "Descripcion", "DiasHorarios", "Costo", "CupoMaximo" }
            };

            _filterableDataGridView.EditClicked += OnEditClicked;
            _filterableDataGridView.DeleteClicked += OnDeleteClicked;

            Controls.Add(_filterableDataGridView);
        }

        private void OnEditClicked(Actividad actividad)
        {
            var editSocioForm = ActividadForm.CreateActividadForm(_club, actividad);

            if (editSocioForm == null || editSocioForm.ShowDialog() != DialogResult.OK) return;
        }

        private void OnDeleteClicked(Actividad actividad)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta actividad?", "Eliminar actividad",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.EliminarActividad(actividad.ID);
        }
    }
}