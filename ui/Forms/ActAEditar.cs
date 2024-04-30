using System;
using System.Windows.Forms;
using Negocio.Modelos;

namespace UI
{
    public partial class ActAEditar : Form
    {
        private readonly Club _club;
        private readonly int _i;
        private readonly ClubForm _cf;
        public ActAEditar(Club club, int i, ClubForm cf)
        {

            InitializeComponent();
            CenterToScreen();

            _club = club;
            _i = i;
            _cf = cf;

        }

        public void mostrarInfo(Actividad act)
        {
            //nombreTextBox.Text = act.Nombre.ToString();
            //descTextBox.Text = act.Descripcion.ToString();
            //dyhTextBox.Text = act.DiasHorarios.ToString();
            //costoTextBox.Text = act.Costo.ToString();
            //cmTextBox.Text = act.CupoMaximo.ToString();
            // profesorComboBox.SelectedItem = act.Profesor;
        }


        private void buttConfirmEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) || string.IsNullOrWhiteSpace(descTextBox.Text) || string.IsNullOrWhiteSpace(dyhTextBox.Text) ||
                string.IsNullOrWhiteSpace(costoTextBox.Text) || string.IsNullOrWhiteSpace(cmTextBox.Text) /*|| profesorComboBox.SelectedItem == null*/)
            {
                MessageBox.Show("No puede dejar campos en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Actividad act = new Actividad(nombreTextBox.Text.ToLower(), descTextBox.Text, dyhTextBox.Text, double.Parse(costoTextBox.Text), int.Parse(cmTextBox.Text) /*profesorComboBox.SelectedItem*/);
                //_club.EditarActividad(act, _i);
                //_cf.ActualizarActividadesListView();
                //DialogResult = DialogResult.OK;
                //Close();
            }
        }
    }
}
