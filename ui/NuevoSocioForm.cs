using System.Windows.Forms;
using Negocio;

namespace UI
{
    public partial class NuevoSocioForm : Form
    {


        public Socio Socio { get; set; }

        public NuevoSocioForm()
        {
            InitializeComponent();
            CenterToParent();


        }

        private void crearSocioButton_Click(object sender, System.EventArgs e)
        {
            var socio = new Socio
            {
                Nombre = nombreTextBox.Text,
                Apellido = apellidoTextBox.Text,
                DNI = dniTextBox.Text,
            };

            Socio = socio;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
