using Negocio.Modelos;
using System;
using System.Web.UI;


namespace Web
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var socio = (Socio)Session["Socio"];

                cargarActividades(socio);
            }
        }

        protected void ButtonInscribirse_Click(object sender, EventArgs e)
        {
            var club = (Club)Session["Club"];
            var socio = (Socio)Session["Socio"];

            if (ListBoxActividades.SelectedItem != null)
            {

                var actividad = int.Parse(ListBoxActividades.SelectedItem.Value);

                try
                {
                    club.InscribirSocioActividad(socio.ID, actividad);
                    LabelMensaje.ForeColor = System.Drawing.Color.Green;
                    LabelMensaje.Text = "El socio fue inscrito con éxito.";
                    cargarActividades(socio); // Actualiza la lista de actividades
                }
                catch (Exception ex)
                {
                    LabelMensaje.ForeColor = System.Drawing.Color.Red;
                    LabelMensaje.Text = ex.Message;
                }

            }
        }

        protected void cargarActividades(Socio socio)
        {
            var club = (Club)Session["Club"];

            ListBoxActividades.DataSource = club.GetActividadesDisponiblesSocio(socio.ID);
            ListBoxActividades.DataTextField = "Nombre";
            ListBoxActividades.DataValueField = "ID";
        
            ListBoxActividades.DataBind();
        }

    }

}