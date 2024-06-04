using System;
using System.Windows.Forms;
using Negocio.Modelos;
using UI.Forms;
using UI.Forms.Socios;

namespace UI
{
    public partial class ClubForm : Form
    {
        private readonly Club _club = new Club();


        public ClubForm()
        {
            InitializeComponent();
            CenterToScreen();
        }


        public void ActualizarActividadesListView()
        {
            //actividadesListView.Items.Clear();

            //foreach (var item in _club.Socios.Select(socio => new ListViewItem(new[] { socio.DNI.ToString(), socio.Nombre, socio.Apellido, socio.CuotaSocial.ToString(CultureInfo.CurrentCulture) })))
            //{
            //    sociosListView.Items.Add(item);
            //}
        }


        private void CrearSocio(object sender, EventArgs e)
        {
            var nuevoSocioForm = new SocioForm(_club);

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;
        }

        private void CrearActividad_Click(object sender, EventArgs e)
        {
            var actividadForm = ActividadForm.CreateActividadForm(_club);

            if (actividadForm == null || actividadForm.ShowDialog() != DialogResult.OK) return;

            ActualizarActividadesListView();
        }

        private void verSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevoSocioForm = new SociosForm(_club);

            nuevoSocioForm.ShowDialog();
        }

        private void verProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profesoresForm = new ProfesoresForm(_club);

            profesoresForm.ShowDialog();
        }

        private void nuevoProfesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var profesorForm = new ProfesorForm(_club);

            profesorForm.ShowDialog();
        }

        private void verActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actividadesForm = new ActividadesForm(_club);

            actividadesForm.ShowDialog();
        }

        private void generarParaTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea generar la orden de pago para todos los socios?",
                        "Generar orden de pago",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


                _club.GenerarOrdenesPagoSocios();

                MessageBox.Show("Ordenes de pago generadas correctamente", "Ordenes de pago generadas", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sociosSinPagar = new SociosSinPagarForm(_club);

            sociosSinPagar.ShowDialog();
        }

    }
}