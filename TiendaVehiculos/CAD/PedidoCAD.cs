using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using Libreria.EN;

namespace TiendaVehiculos.CAD
{
    class PedidoCAD
    {
        private ConexionCAD conexion;
        private SqlDataReader lector;
        private SqlCommand consulta;


        //Insertar Pedido en la base de datos
        public void insertarPedido(int numPedido, string usuario)
        {
            try
            {
                
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("INSERT INTO pedido (num_pedido, fecha, cliente) VALUES(" + numPedido + ", GETDATE(),'" + usuario + "')", conexion.Conectar());
                consulta.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                conexion.Desconectar();
            }
        }

        // Metodo que sacara un numero de pedido de la base de datos
        public int extraerNumPedidoCAD(int num)
        {
            int count = 0;
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("SELECT COUNT(*) FROM pedido WHERE num_pedido=" + num, conexion.Conectar());
                count = Convert.ToInt32(consulta.ExecuteScalar());
            }
            catch (Exception e)
            {
            }
            finally
            {
                conexion.Desconectar();
            }
            return count;
        }

        // Update de Pedido
        public void modificaPedidoCAD(/* parametros de Pedido */)
        {

        }

        // Delete de Pedido
        public void eliminaPedidoCAD(int num_pedido)
        {

        }

    }
}
