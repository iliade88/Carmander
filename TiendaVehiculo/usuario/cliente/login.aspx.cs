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

     
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            UsuarioEN usuario;
            usuario=new UsuarioEN();
            string username = Login1.UserName;
            string pwd = Login1.Password;

            if (usuario.comprobarUsuario(username, pwd))
            {
                Response.Redirect("Default.apx");
            }
            else
            {
                Response.Redirect("contacta.apx");
            }

        }

        

    }
}