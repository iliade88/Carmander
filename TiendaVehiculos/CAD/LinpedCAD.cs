using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TiendaVehiculos.CAD
{
    public class LinpedCAD
    {
        private ConexionCAD conexion;
        private SqlCommand consulta;
        private SqlDataReader lector;
        private ArrayList lista;

        // Select de la tabla Linped
        public SqlDataReader leeTablaLinpedCAD()
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

        // Metodo que insertara una linea de Pedido en la BBDD
        public void insertaLinpedCAD(int numLinea, decimal precio, int cantidad, int numPedido, string articulo)
        {
            // Creamos un parametro para el valor decimal
            SqlParameter paramPvp = new SqlParameter("@pvp", System.Data.SqlDbType.Decimal);
            // Le asignamos la variable de pvp
            paramPvp.Value = precio;
            string insert = "INSERT INTO linped (linea, precio, cantidad, pedido, articulo) VALUES("+numLinea+",@pvp,"+cantidad+","+numPedido+",'"+articulo+"')";
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand(insert, conexion.Conectar());
                // Añadimos el parametro a la consulta
                consulta.Parameters.Add(paramPvp);
                // Lanzamos la query
                consulta.ExecuteNonQuery();
            }
            catch (Exception e)
            { }
            finally
            {
                conexion.Desconectar();
            }
        }

        // Update de Linped
        public void modificaLinpedCAD(/* parametros de Linped */)
        {

        }

        // Delete de Linped
        public void eliminaLinpedCAD(int linea, int pedido)
        {

        }
    }
}
