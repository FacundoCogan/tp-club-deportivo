using Negocio.Modelos;
using System;
using System.Web;
using System.Web.UI;

namespace Web
{
    public partial class Login : Page
    {
        private readonly Club _club = new Club();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Si el usuario ya está autenticado, redirigir a la página principal
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("Default.aspx");
            }


            if (!IsPostBack)
            {
                Session["Club"] = _club;
            }
        } 

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            var usuario = _club.BuscarUsuario(username);

            if (usuario != null && password == "12345")
            {

                // Autenticación exitosa
                Session["Socio"] = usuario;

                // Crea la cookie de autenticación
                System.Web.Security.FormsAuthentication.SetAuthCookie(username, false);

                // Redirige a la página predeterminada después del login
                Response.Redirect("Default.aspx");

            }
            else
            {
                // Autenticación fallida
                LabelMessage.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
