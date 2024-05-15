using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
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
            _filterableDataGridView.GenerateOrderClicked += OnGenerateClicked;

            Controls.Add(_filterableDataGridView);
        }

        private void LoadSociosData()
        {
            var dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Cuota Social", typeof(decimal));

            foreach (var socio in _club.Socios)
            {
                dt.Rows.Add(socio.ID, socio.DNI, socio.Nombre, socio.Apellido, socio.CuotaSocial);
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
                (int)rowData.Cells["ID"].Value,
                (int)rowData.Cells["DNI"].Value,
                (string)rowData.Cells["Nombre"].Value,
                (string)rowData.Cells["Apellido"].Value,
                (decimal)rowData.Cells["Cuota Social"].Value);

            var editSocioForm = new SocioForm(_club, socio);

            if (editSocioForm.ShowDialog() != DialogResult.OK) return;

            LoadSociosData();
        }

        private void OnDeleteClicked(int rowIndex, DataGridViewRow rowData)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este socio?", "Eliminar socio",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _club.DarBajaSocio((int)rowData.Cells["ID"].Value);

            LoadSociosData();
        }

        private void OnGenerateClicked(int rowIndex, DataGridViewRow rowData)
        {
            var socio = new SocioClub(
            (int)rowData.Cells["ID"].Value,
            (int)rowData.Cells["DNI"].Value,
            (string)rowData.Cells["Nombre"].Value,
            (string)rowData.Cells["Apellido"].Value,
            (decimal)rowData.Cells["Cuota Social"].Value);

            _club.GenerarOrdenPagoSocio(socio);
        }


    }
}