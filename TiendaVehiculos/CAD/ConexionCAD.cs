﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TiendaVehiculos.CAD
{
    // Clase que controlara la conexion con la base de datos
    public class ConexionCAD
    {        
        private SqlConnection conexion;

        // Cadena de conexion a la BBDD
        //private string cadenaConexion = "Data Source=(LocalDB)\v11.0;AttachDBFilename=|DataDirectory|\\DBDTienda.mdf;Integrated Security=True";
        //string s = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\Jorge\\Desktop\\GIT\\TiendaVehiculo\\App_Data\\Database1.mdf;Integrated Security=True";//"data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database1.mdf;User Instance=true;";
        private string cadenaConexion = "Data Source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database1.mdf;User Instance=true";


        // Conexion a la base de datos
        public SqlConnection Conectar()
        {
            conexion = new SqlConnection(cadenaConexion);
           conexion.Open();
            return conexion;
        }

        // Desconexion a la base de datos
        public void Desconectar()
        {
            conexion.Close();
        }
    }
}
