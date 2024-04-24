using System;
using System.Windows.Forms;
using Negocio;

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

        private void ActualizarSociosListView()
        {
            sociosListView.Items.Clear();

            foreach (var socio in _club.Socios)
            {
                var item = new ListViewItem(socio.DNI.ToString());
                item.SubItems.Add(socio.Nombre);
                item.SubItems.Add(socio.Apellido);

                sociosListView.Items.Add(item);
            }
        }

        public void ActualizarActividadesListView()
        {

            actividadesListView.Items.Clear();

            foreach (var actividad in _club.Actividades)
            {
                var item = new ListViewItem(actividad.Nombre);
                item.SubItems.Add(actividad.DiasHorarios);
                item.SubItems.Add(actividad.Costo.ToString());
                item.SubItems.Add(actividad.CupoMaximo.ToString());
                // item.SubItems.Add(actividad.Profesor.Nombre);

                actividadesListView.Items.Add(item);
            }
        }


        private void CrearSocio(object sender, EventArgs e)
        {
            var nuevoSocioForm = new NuevoSocioForm(_club);

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;

            ActualizarSociosListView();
        }

        private void CrearActividad_Click(object sender, EventArgs e)
        {
            var actividadForm = new ActivForm(_club);

            if (actividadForm.ShowDialog() != DialogResult.OK) return;

            ActualizarActividadesListView();
        }

        private void buttEditar_Click(object sender, EventArgs e)
        {

            if(_club.Actividades.ToArray().Length == 0)
            {
                MessageBox.Show("No hay actividades para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccionarActForm = new SeleccionarActForm(_club, this);

            foreach (var actividad in _club.Actividades)
            {
                seleccionarActForm.mostrar(actividad);
            }

            if (seleccionarActForm.ShowDialog() != DialogResult.OK) return;


        }

        private void buttEliminarAct_Click(object sender, EventArgs e)
        {
            if (_club.Actividades.ToArray().Length == 0)
            {
                MessageBox.Show("No hay actividades para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seleccionarActAElim = new SeleccionarActAElim(_club, this);

            foreach (var actividad in _club.Actividades)
            {
                seleccionarActAElim.mostrar(actividad);
            }

            if (seleccionarActAElim.ShowDialog() != DialogResult.OK) return;
        }
    }
}
