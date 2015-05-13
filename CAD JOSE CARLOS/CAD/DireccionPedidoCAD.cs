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
    public class DireccionPedidoCAD
    {
        private ConexionCAD conexion;
        private SqlDataReader lector;
        private SqlCommand consulta;

        // Select de la tabla DireccionPedido
        public ArrayList leeTablaDireccionPedidoCAD()
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

        // Metodo que insertara una direccion de pedido
        public void insertaDireccionPedidoCAD(string usuario, string direccion, string codigoPostal, int localidad, int provincia)
        {
            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("INSERT INTO direccion_pedido (email, calle, cod_postal, codigo_local, provincia_local) VALUES('" + usuario + "', '" + direccion + "','" + codigoPostal + "'," + localidad + "," + provincia + ")", conexion.Conectar());
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

        // Update de Pedido
        public void modificaDireccionPedidoCAD(/* parametros de Pedido */)
        {

        }

        // Delete de Pedido
        public void eliminaDireccionPedidoCAD(string email)
        {

        }
    }
}
