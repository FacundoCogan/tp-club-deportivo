using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ProfesoresForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView<Profesor> _filterableDataGridView;

        public ProfesoresForm(Club club)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView<Profesor>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.Profesores,
                DisplayProperties = new List<string> { "ID", "DNI", "Nombre", "Apellido", "Especialidad" }
            };

            _filterableDataGridView.AddCustomButton("Ver actividades", OnViewActivitiesClicked);
            _filterableDataGridView.AddEditButton(OnEditClicked);
            _filterableDataGridView.AddDeleteButton(OnDeleteClicked);

            Controls.Add(_filterableDataGridView);
        }

        private void OnViewActivitiesClicked(Profesor profesor)
        {
            var actividadesProfesorForm = new ActividadesProfesorForm(_club, profesor);

            actividadesProfesorForm.ShowDialog();
        }

        private void OnEditClicked(Profesor profesor)
        {
            var profesorForm = new ProfesorForm(_club, profesor);

            profesorForm.ShowDialog();

            if (profesorForm.DialogResult != DialogResult.OK) return;
        }

        private void OnDeleteClicked(Profesor profesor)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este profesor?", "Eliminar profesor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.DarBajaProfesor(profesor.ID);
        }
    }
}