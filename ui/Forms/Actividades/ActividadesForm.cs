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

            _filterableDataGridView.AddEditButton(OnEditClicked);
            _filterableDataGridView.AddDeleteButton(OnDeleteClicked);

            Controls.Add(_filterableDataGridView);
        }

        private void OnEditClicked(Actividad actividad)
        {
            var editSocioForm = ActividadForm.CreateActividadForm(_club, actividad);

            editSocioForm.ShowDialog();
        }

        private void OnDeleteClicked(Actividad actividad)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta actividad?", "Eliminar actividad",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                _club.EliminarActividad(actividad.ID);

                MessageBox.Show("Actividad eliminada correctamente", "Actividad eliminada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar la actividad", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}