using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Controls;

namespace UI.Forms.Socios
{
    public partial class SeleccionarOrdenForm : Form
    {
        private readonly Club _club;
        private readonly Socio _socio;
        private FilterableDataGridView<OrdenPago> _filterableDataGridView;

        public SeleccionarOrdenForm(Club club, Socio socio)
        {
            _club = club;  
            _socio = socio;
            InitializeComponent();
            CenterToParent();
            SetupCustomDataGridView();
        }

        private void SetupCustomDataGridView()
        {
            _filterableDataGridView = new FilterableDataGridView<OrdenPago>
            {
                Dock = DockStyle.Fill,
                DataFetcher = () => _club.GetOrdenesPendientes(_socio.ID),
                DisplayProperties = new List<string> {"ID", "SocioID", "Monto", "Fecha"}
            };

            _filterableDataGridView.AddCustomButton("Registrar pago", OnRegisterPaymentClicked);

            Controls.Add(_filterableDataGridView);

        }

        private void OnRegisterPaymentClicked(OrdenPago ordenPago)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar este pago?", "Registrar pago",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                _club.RegistrarPagoSocio(ordenPago);

                MessageBox.Show("Pago registrado correctamente", "Pago registrado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
