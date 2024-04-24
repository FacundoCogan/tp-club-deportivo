using System;
using System.Windows.Forms;
using Negocio;

namespace UI
{
    public partial class SeleccionarActAElim : Form
    {
        private readonly Club _club;
        private readonly ClubForm _cf;
        public SeleccionarActAElim(Club club, ClubForm cf)
        {
            InitializeComponent();
            CenterToScreen();

            _club = club;
            _cf = cf;
        }

        public void mostrar(Actividad act)
        {
            elimComboBox.Items.Add(act.Nombre);
        }

        private void buttConfirmElim_Click(object sender, EventArgs e)
        {
            if (elimComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Actividad act = _club.BuscarActividad(elimComboBox.SelectedItem.ToString().ToLower());
                int i = _club.BuscarIndice(act);
                _club.EliminarActividad(i);
                _cf.ActualizarActividadesListView();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
