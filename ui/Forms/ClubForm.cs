using System;
using System.Windows.Forms;
using Negocio.Modelos;

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
            var nuevoSocioForm = new NuevoSocioForm(_club);

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;
        }

        private void CrearActividad_Click(object sender, EventArgs e)
        {
            var actividadForm = new ActivForm(_club);

            if (actividadForm.ShowDialog() != DialogResult.OK) return;

            ActualizarActividadesListView();
        }

        private void buttEditar_Click(object sender, EventArgs e)
        {
            if (_club.Actividades.ToArray().Length == 0)
            {
                MessageBox.Show("No hay actividades para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccionarActForm = new SeleccionarActividadForm(_club, this);

            foreach (var actividad in _club.Actividades) seleccionarActForm.mostrar(actividad);

            if (seleccionarActForm.ShowDialog() != DialogResult.OK) return;
        }

        private void buttEliminarAct_Click(object sender, EventArgs e)
        {
            if (_club.Actividades.ToArray().Length == 0)
            {
                MessageBox.Show("No hay actividades para eliminar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var seleccionarActAElim = new SeleccionarActAElim(_club, this);

            foreach (var actividad in _club.Actividades) seleccionarActAElim.mostrar(actividad);

            if (seleccionarActAElim.ShowDialog() != DialogResult.OK) return;
        }

        private void verSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevoSocioForm = new SociosForm(_club);

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;
        }
    }
}