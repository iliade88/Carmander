using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaVehiculos.EN;

namespace TiendaVehiculo.usuario.cliente
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //si no esta registrado, generamos el hipervinculo a registro
            RegisterHyperLink.NavigateUrl = "Registro.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }


        // Metodo que se lanzara cuando se haga clic en el boton de buscar
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string login, password;
            UsuarioEN UsuarioEN = new UsuarioEN();
            // Extraemos el ContentPlaceHolder que vamos a editar
            TiendaVehiculos.EN.UsuarioEN.Usuario c = new TiendaVehiculos.EN.UsuarioEN.Usuario();
            //LabelErrorLoginID.Visible = false;
            // Si la validacion es correcta
            if (Page.IsValid)
            {
                // Extraemos los datos del formulario
                login = Request.Form[TextBoxLoginID.UniqueID].ToString();
                password = Request.Form[TextBoxPassID.UniqueID].ToString();
                // Enviamos los datos a la EN
                if (UsuarioEN.compruebaUsuarioEN(login, password))
                {
                    // Creamos las sesiones
                    Session.Add("logUser", login);
                    Session.Add("passUser", password);
                    // Redireccionamos al panel de control del administrador
                    Response.Redirect("Inicio.aspx");
                }
                else // Si no, mostramos mensaje de error
                {
                    LabelErrorLoginID.Visible = true;
                    LabelErrorLoginID.Text = "Error!";
                    LabelErrorLoginID.ForeColor = System.Drawing.Color.Red;
                }
            }
            // Colocamos el foco en el textbox de login
            TextBoxLoginID.Focus();
        }

        

    }
}