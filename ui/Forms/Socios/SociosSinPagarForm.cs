using Negocio.Modelos;
using System.Windows.Forms;
using UI.Controls;
using System.Collections.Generic;

namespace UI.Forms.Socios
{
    public partial class SociosSinPagarForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView<Socio> _filterableDataGridView;

        public SociosSinPagarForm(Club club)
        {
            _club = club;
            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView<Socio>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.SociosSinPagar,
                DisplayProperties = new List<string> { "ID", "DNI", "Nombre", "Apellido", "CuotaSocial" }
            };

            _filterableDataGridView.AddCustomButton("Ver órdenes", OnViewOrdersClicked);

            Controls.Add(_filterableDataGridView);
        }

        private void OnViewOrdersClicked(Socio socio)
        {
            var seleccionarOrdenForm = new SeleccionarOrdenForm(_club, socio);

            seleccionarOrdenForm.ShowDialog();
        }
    }
}
