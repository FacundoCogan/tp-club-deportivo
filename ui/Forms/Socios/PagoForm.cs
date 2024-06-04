using Negocio.Modelos;
using System;
using System.Windows.Forms;

namespace UI.Forms.Socios
{
    public partial class PagoForm : Form
    {
        private readonly Club _club;
        private readonly OrdenPago _ordenPago;

        public PagoForm(Club club, OrdenPago ordenPago)
        {
            _club = club;
            _ordenPago = ordenPago;
            InitializeComponent();
            CenterToParent();

            montoAPagarTextBox.Text = _ordenPago.Monto.ToString();
        }

        private void buttConfirmarPago_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(montoADebitarTextBox.Text, out decimal montoADebitar))
            {
                MessageBox.Show("Debe ingresar un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.Parse(montoADebitarTextBox.Text) != _ordenPago.Monto)
            {
                MessageBox.Show("El monto a debitar no coincide con lo que debe pagar el socio", "Error", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (MessageBox.Show("¿Está seguro que desea registrar este pago?", "Registrar pago",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                _club.RegistrarPagoSocio(_ordenPago);

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
