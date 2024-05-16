using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Controls;

namespace UI.Forms
{
    public partial class SociosForm : Form
    {
        private readonly Club _club;
        private FilterableDataGridView<Socio> _filterableDataGridView;

        public SociosForm(Club club)
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
                DataFetcher = () => _club.Socios,
                DisplayProperties = new List<string> { "ID", "DNI", "Nombre", "Apellido", "CuotaSocial" }
            };

            _filterableDataGridView.AddCustomButton("Generar orden", OnGeneratePaymentOrderClicked);

            _filterableDataGridView.EditClicked += OnEditClicked;
            _filterableDataGridView.DeleteClicked += OnDeleteClicked;

            Controls.Add(_filterableDataGridView);
        }

        private void OnEditClicked(Socio socio)
        {
            var editSocioForm = new SocioForm(_club, socio);

            editSocioForm.ShowDialog();
        }

        private void OnDeleteClicked(Socio socio)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este socio?", "Eliminar socio",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                _club.DarBajaSocio(socio.ID);

                MessageBox.Show("Socio eliminado correctamente", "Socio eliminado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnGeneratePaymentOrderClicked(Socio socio)
        {
            try
            {
                _club.GenerarOrdenPagoSocio(socio);

                MessageBox.Show("Orden de pago generada correctamente", "Orden de pago generada", MessageBoxButtons.OK,
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