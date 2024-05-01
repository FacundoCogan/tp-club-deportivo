using System.Data;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ProfesoresForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView _filterableDataGridView;

        public ProfesoresForm(Club club)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
            LoadProfesoresData();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView
            {
                Dock = DockStyle.Fill
            };

            _filterableDataGridView.EditClicked += OnEditClicked;
            _filterableDataGridView.DeleteClicked += OnDeleteClicked;

            Controls.Add(_filterableDataGridView);
        }

        private void LoadProfesoresData()
        {
            var dt = new DataTable();

            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Especialidad", typeof(string));

            foreach (var socio in _club.Profesores)
            {
                dt.Rows.Add(socio.DNI, socio.Nombre, socio.Apellido, socio.Especialidad);
            }

            _filterableDataGridView.DataSource = dt;
        }

        private void OnEditClicked(int rowIndex, DataGridViewRow rowData)
        {
            var profesor = new Profesor(
                (int)rowData.Cells["DNI"].Value,
                (string)rowData.Cells["Nombre"].Value,
                (string)rowData.Cells["Apellido"].Value,
                (string)rowData.Cells["Especialidad"].Value);

            var profesorForm = new ProfesorForm(_club, profesor);

            profesorForm.ShowDialog();

            if (profesorForm.DialogResult != DialogResult.OK) return;

            LoadProfesoresData();
        }

        private void OnDeleteClicked(int rowIndex, DataGridViewRow rowData)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este profesor?", "Eliminar profesor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.DarBajaProfesor((int)rowData.Cells["DNI"].Value);

            LoadProfesoresData();
        }
    }
}