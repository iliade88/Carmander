using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TiendaVehiculos.CAD
{
    public class LocalidadCAD
    {
        private ConexionCAD conexion;

        // Select de la tabla Localidad
        public SqlDataReader leeTablaLocalidadCAD()
        {
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            // Leemos


            // Desconectamos
            conexion.Desconectar();
            // Damos datos al EN
            return null;
        }

        // Update de Localidad
        public void modificaLocalidadCAD(/* parametros de Localidad */)
        {

        }

        // Delete de Localidad
        public void eliminaLocalidadCAD(int codigo, int provincia)
        {

        }
    }
}
