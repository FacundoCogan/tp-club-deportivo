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
                var item = new ListViewItem(socio.ToString());

                sociosListView.Items.Add(item);
            }
        }

        private void CrearSocio(object sender, EventArgs e)
        {
            var nuevoSocioForm = new NuevoSocioForm();

            if (nuevoSocioForm.ShowDialog() != DialogResult.OK) return;

            _club.CrearSocio(nuevoSocioForm.Socio);

            ActualizarSociosListView();
        }
    }
}
