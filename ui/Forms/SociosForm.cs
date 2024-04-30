using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI
{
    public partial class SociosForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView _filterableDataGridView;

        public SociosForm(Club club)
        {
            _club = club;

            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
            LoadSociosData();
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

        private void LoadSociosData()
        {
            var dt = new DataTable();

            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Cuota Social", typeof(decimal));

            foreach (var socio in _club.Socios)
            {
                dt.Rows.Add(socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
            }

            _filterableDataGridView.DataSource = dt;

            // Set currency format
            _filterableDataGridView.Columns["Cuota Social"].DefaultCellStyle.Format = "C2";
            _filterableDataGridView.Columns["Cuota Social"].DefaultCellStyle.FormatProvider =
                CultureInfo.GetCultureInfo("es-AR");
        }

        private void OnEditClicked(int rowIndex, DataGridViewRow rowData)
        {
            var socio = new SocioClub(
                (int)rowData.Cells["DNI"].Value,
                (string)rowData.Cells["Nombre"].Value,
                (string)rowData.Cells["Apellido"].Value,
                (decimal)rowData.Cells["Cuota Social"].Value);

            var editSocioForm = new NuevoSocioForm(_club, socio);

            editSocioForm.ShowDialog();

            if (editSocioForm.DialogResult != DialogResult.OK) return;

            LoadSociosData();
        }

        private void OnDeleteClicked(int rowIndex, DataGridViewRow rowData)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este socio?", "Eliminar socio",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.DarBajaSocio((int)rowData.Cells["DNI"].Value);

            LoadSociosData();
        }
    }
}