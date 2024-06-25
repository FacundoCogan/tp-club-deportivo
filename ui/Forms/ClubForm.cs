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
            CenterToParent();
        }

        private void CrearSocio(object sender, EventArgs e)
        {
            var nuevoSocioForm = new SocioForm(_club);

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;
        }

        private void CrearActividad_Click(object sender, EventArgs e)
        {
            var actividadForm = ActividadForm.CreateActividadForm(_club);

            actividadForm.ShowDialog();
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
            if (_club.SociosSinOrden.Count == 0)
            {
                MessageBox.Show("Ya se le ha generado una orden de pago a todos los socios en el corriente mes.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (MessageBox.Show("¿Está seguro que desea generar la orden de pago para todos los socios?",
                        "Generar orden de pago",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


                _club.GenerarOrdenesPagoSocios();

                MessageBox.Show("Ordenes de pago generadas correctamente", "Ordenes de pago generadas",
                    MessageBoxButtons.OK,
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
            if (_club.SociosSinPagar.Count == 0)
            {
                MessageBox.Show("Todos los socios tienen el pago al día.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var sociosSinPagar = new SociosSinPagarForm(_club);

            sociosSinPagar.ShowDialog();
        }

        private void ClubForm_Load(object sender, EventArgs e)
        {
            labelSocios.Text = _club.Socios.Count.ToString();
            labelActividades.Text = _club.Actividades.Count.ToString();
            labelProfesores.Text = _club.Profesores.Count.ToString();
            labelOrdenes.Text = _club.OrdenesImpagas.ToString();
        }
    }
}