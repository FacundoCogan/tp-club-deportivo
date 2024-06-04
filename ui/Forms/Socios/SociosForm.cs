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

            _filterableDataGridView.AddCustomButton("Inscribir", OnEnrollClicked);
            _filterableDataGridView.AddCustomButton("Ver actividades", OnViewActivitiesClicked);
            _filterableDataGridView.AddCustomButton("Generar orden", OnGeneratePaymentOrderClicked);
            _filterableDataGridView.AddEditButton(OnEditClicked);
            _filterableDataGridView.AddDeleteButton(OnDeleteClicked);

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

        private void OnEnrollClicked(Socio socio)
        {
            var inscribirSocioForm = new InscribirSocioActividadForm(_club, socio);

            inscribirSocioForm.ShowDialog();
        }

        private void OnViewActivitiesClicked(Socio socio)
        {
            var actividadesSocioForm = new ActividadesSocioForm(_club, socio);

            actividadesSocioForm.ShowDialog();
        }

        private void OnGeneratePaymentOrderClicked(Socio socio)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea generar la orden de pago para este socio?",
                        "Generar orden de pago",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


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