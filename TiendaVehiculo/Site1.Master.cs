﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaVehiculo
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["login"] == null)
            {
                Identi.Text = "Dentro";

            }
            else { 
                Identi.Text= "<a href='/usuario/cliente/login.aspx'>Identificarse </a>";
            }
            

        }
    }
}