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

        protected void aceptado_Click(object sender, EventArgs e)
        {
            UsuarioEN user = new UsuarioEN();

            if (user.InsertarUsuarios(DNI.Text, Correo.Text, Nombre.Text, Apellido1.Text, Apellido2.Text, day.Text, Contraseña.Text))
            {

                Label1.Text = "Usuario Registrado";

            }
            else {
                Label1.Text = "Usuario no registrado campos incorrectos";
            }
            
           
             

            
        
        
        }
    }
}