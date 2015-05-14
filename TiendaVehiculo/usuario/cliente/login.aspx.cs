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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioEN user = new UsuarioEN();
            if (user.comprobarUsuario(email.Text, pass.Text))
            {
                Session["login"] = email.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Text = "Usuario o contraseña incorrecta";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

    }
}