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
    public class CarritoCAD
    {
        private ConexionCAD conexion;
        private ArrayList lista;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public ArrayList leerCarritoCAD(string usuario)
        {
            lista = new ArrayList();
            // Conectamos con la conexionCAD
            conexion = new ConexionCAD();
            conexion.Conectar();
            //Consulta SQL que devolvera todo lo que tenga la cesta
            consulta = new SqlCommand("SELECT * FROM carrito WHERE cliente='"+usuario+"'", conexion.Conectar());
            // Leemos la query y la almacenamos
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(lector["cliente"].ToString());
                lista.Add(lector["vehiculo"].ToString());
                lista.Add(lector["cantidad"].ToString());
                lista.Add(lector["fecha"].ToString());
            }
            lector.Close();

            conexion.Desconectar();
            return lista;
        }


        // Metodo que elimine el carrito de un usuario
        public void eliminaCarritoPorUsuarioCAD(string usuario)
        {
            try
            {
                // Conectamos con la conexionCAD
                conexion = new ConexionCAD();
                conexion.Conectar();
                //Consulta SQL que BORRARA el carrito del cliente pasado por parametro
                consulta = new SqlCommand("DELETE FROM carrito WHERE cliente = '" + usuario + "';", conexion.Conectar());
                // Lanzamos la query directamente
                consulta.ExecuteNonQuery();
            }
            catch (Exception e)
            { }
            finally
            {
                conexion.Desconectar();
            }
        }

        //Insertar datos en el carrito
        public void insertaCarritoCAD(string cliente, string vehiculo, int cantidad)
        {
            conexion = new ConexionCAD();
            conexion.Conectar();
           
            consulta = new SqlCommand("Insert Into cesta (cliente, articulo, cantidad, fecha) VALUES ('" + cliente + "','" + vehiculo + "'," + cantidad + ",GETDATE())", conexion.Conectar());
            
            consulta.ExecuteNonQuery();
            conexion.Desconectar();
        }

        // Update del carrito
        public void modificaCestaCAD(string cliente, string vehiculo, int cantidad, DateTime fecha)
        {
            conexion = new ConexionCAD();
            conexion.Conectar();
            consulta = new SqlCommand("update carrito set cliente = " + cliente + ",vehiculo=" + vehiculo + ",cantidad" + cantidad + "fecha=" + fecha + "where cliente =" + cliente + "and vehiculo=" + vehiculo);
        }

        // Delete de carrito
        public void eliminaCestaCAD(string cliente, string vehiculo)
        {
            conexion = new ConexionCAD();
            conexion.Conectar();
            consulta = new SqlCommand("delete from carrito where cliente =" + cliente + "and vehiculo = " + vehiculo, conexion.Conectar());
        }
    }
}
