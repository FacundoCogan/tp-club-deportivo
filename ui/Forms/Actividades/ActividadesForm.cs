using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class ActividadesForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView _filterableDataGridView;

        public ActividadesForm(Club club)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
            LoadActividadesData();
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

        private void LoadActividadesData()
        {
            var dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Dias y Horarios", typeof(string));
            dt.Columns.Add("Costo", typeof(decimal));
            dt.Columns.Add("Cupo Máximo", typeof(int));

            foreach (var actividad in _club.Actividades)
            {
                dt.Rows.Add(actividad.ID, actividad.Nombre, actividad.Descripcion, actividad.DiasHorarios,
                    actividad.Costo, actividad.CupoMaximo);
            }

            _filterableDataGridView.DataSource = dt;

            _filterableDataGridView.Columns["Costo"].DefaultCellStyle.Format = "C2";
            _filterableDataGridView.Columns["Costo"].DefaultCellStyle.FormatProvider =
                CultureInfo.GetCultureInfo("es-AR");
        }

        private void OnEditClicked(int rowIndex, DataGridViewRow rowData)
        {
            var actividad = new Actividad(
                (int)rowData.Cells["ID"].Value,
                (string)rowData.Cells["Nombre"].Value,
                (string)rowData.Cells["Descripción"].Value,
                (string)rowData.Cells["Dias y Horarios"].Value,
                (decimal)rowData.Cells["Costo"].Value,
                (int)rowData.Cells["Cupo Máximo"].Value);


            var editSocioForm = ActividadForm.CreateActividadForm(_club, actividad);

            if (editSocioForm == null || editSocioForm.ShowDialog() != DialogResult.OK) return;

            LoadActividadesData();
        }

        private void OnDeleteClicked(int rowIndex, DataGridViewRow rowData)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta actividad?", "Eliminar actividad",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.EliminarActividad((int)rowData.Cells["ID"].Value);

            LoadActividadesData();
        }
    }
}