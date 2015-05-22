using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaVehiculos.EN;

namespace TiendaVehiculo.usuario.cliente
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            string dni, email, nombre, ap1, ap2, fechaNacimiento, pass;
            // Recogemos los datos del formulario
            dni = Request.Form[DNI.UniqueID].ToString();
            email = Request.Form[Correo.UniqueID].ToString();
            nombre = Request.Form[Nombre.UniqueID].ToString();
            ap1 = Request.Form[Apellido.UniqueID].ToString();
            ap2 = Request.Form[Apellido2.UniqueID].ToString();
            fechaNacimiento = Request.Form[FN.UniqueID].ToString();
            pass = Request.Form[Contraseña.UniqueID].ToString();


            usuarioEN.insertaUsuarioEN(dni, email, nombre, ap1, ap2, fechaNacimiento, pass);
            Response.Redirect("\\Default.aspx");
        }
    }
}