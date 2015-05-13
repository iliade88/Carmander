using System;
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
	public class VehiculoCAD
	{
		private ConexionCAD conexion;
        private SqlCommand consulta;
        private SqlDataReader lector;
        private ArrayList lista;
		
		
		// Select de la tabla vehiculo
        public ArrayList leeTablaVehiculoCAD()
        {
            lista = new ArrayList();
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("SELECT * FROM vehiculo;", conexion.Conectar());
                // Lanzamos la query
                lector = consulta.ExecuteReader();
                // Colocamos los datos en el array
                while (lector.Read())
                {
                    lista.Add(lector["codigo"]);
                    lista.Add(lector["nombre"]);
                    lista.Add(lector["descripcion"]);
                    lista.Add(lector["pvp"]);
                    lista.Add(lector["url_imagen"]);
					lista.Add(lector["disponible"]);
                }
                // Cerramos el lector
                lector.Close();
            }
            catch (Exception ex)
            { }
            finally 
            {
                // Desconectamos
                conexion.Desconectar();
            }
            // Subimos los datos a la capa de EN
            return lista;
        }
		
		// Insert de vehiculo
        public void insertaVehiculoCAD(string codigo, string nombre, string descripcion, decimal pvp, string urlImagen , bool disponible)
        {
            // Creamos un parametro para el valor decimal
            SqlParameter paramPvp = new SqlParameter("@pvp", System.Data.SqlDbType.Decimal);
            // Le asignamos la variable de pvp
            paramPvp.Value = pvp;
            // Creamos la query con el parametro
            string insert = "INSERT INTO vehiculo (codigo, nombre, descripcion, pvp, url_imagen, disponible) VALUES('" + codigo + "', '" + nombre + "','" + descripcion + "', @pvp ,'" + urlImagen + "','" + disponible + "');";
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
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
		
		
		// Update de vehiculo
        public void modificaVehiculoCAD(string codigo, string nombre, string descripcion, decimal pvp, string urlImagen , bool disponible)
        {
            // Creamos un parametro para el valor decimal
            SqlParameter paramPvp = new SqlParameter("@pvp", System.Data.SqlDbType.Decimal);
            // Le asignamos la variable de pvp
            paramPvp.Value = pvp;
            // Creamos la query con el parametro
            string insert = "UPDATE vehiculo SET nombre='" + nombre + "', descripcion='" + descripcion + "', pvp=@pvp, url_imagen='" + urlImagen + "' WHERE codigo='" + codigo + "';";
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
            catch (Exception ex)
            { }
            finally 
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
		
		// Delete de Vehiculo
        public void eliminaVehiculoCAD(string codigo)
        {
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("DELETE FROM vehiculo WHERE codigo ='" + codigo + "';", conexion.Conectar());
                // Lanzamos la query
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
		
		
		// Select que contara el total de Vehiculos 
        public int cuentaTotalVehiculosCAD()
        {
            int total = 0;
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("SELECT COUNT(*) FROM vehiculo;", conexion.Conectar());
                // Lanzamos la query
                total = Convert.ToInt32(consulta.ExecuteScalar());
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
            // Subimos los datos a la capa de EN
            return total;
        }
		
		public bool compruebaExisteVehiculoCAD(string codigo)
        {
            int total = 0;
            bool existe = false;
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("SELECT COUNT(*) FROM vehiculo WHERE codigo='"+codigo+"';", conexion.Conectar());
                // Lanzamos la query
                total = Convert.ToInt32(consulta.ExecuteScalar());
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
            if (total == 1)
            {
                existe = true;
            }
            // Subimos los datos a la capa de EN
            return existe;
        }
		
		
		// Insert de Vehiculo (COCHE)
        public void insertaVehiculoCocheCAD(string codigo)
        {
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Volvemos a crear otro insert para la tabla
                consulta = new SqlCommand("INSERT INTO coche (vehiculo) VALUES('" + codigo + "')", conexion.Conectar());
                // Lanzamos la query
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
		
		// Insert de Vehiculo (MOTO)
        public void insertaVehiculoMotoCAD(string codigo , string cilindrada)
        {
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Volvemos a crear otro insert para la tabla
                consulta = new SqlCommand("INSERT INTO moto (vehiculo,cilindrada) VALUES('" + codigo + "','" + cilindrada + "')", conexion.Conectar());
                // Lanzamos la query
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
		
		// Insert de Vehiculo (CMAMION)
        public void insertaVehiculoCamionCAD(string codigo , int tara)
        {
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Volvemos a crear otro insert para la tabla
                consulta = new SqlCommand("INSERT INTO camion (vehiculo,tara) VALUES('" + codigo + "','" + tara + "')", conexion.Conectar());
                // Lanzamos la query
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
        }
	}
 
}
