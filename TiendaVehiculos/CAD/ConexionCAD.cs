using System;
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
        private string cadenaConexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\DBDTienda.mdf;User Instance=true";


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
