using System;
using System.Windows.Forms;

using Negocio;

namespace UI
{

    public partial class SeleccionarActForm : Form
    {
        private readonly Club _club;
        private readonly ClubForm _cf;
        public SeleccionarActForm(Club club, ClubForm cf)
        {
            InitializeComponent();
            CenterToScreen();
            _club = club;
            _cf = cf;
        }

        public void mostrar(Actividad act)
        {
            actComboBox.Items.Add(act.Nombre);
        }
        private void buttEditAct_Click(object sender, EventArgs e)
        {
            if (actComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Actividad act = _club.BuscarActividad(actComboBox.SelectedItem.ToString().ToLower());
                int i = _club.BuscarIndice(act);
                ActAEditar actAEditar = new ActAEditar(_club, i, _cf);
                actAEditar.mostrarInfo(act);
                actAEditar.ShowDialog();
                this.Close();
            }

        }
    }
}
