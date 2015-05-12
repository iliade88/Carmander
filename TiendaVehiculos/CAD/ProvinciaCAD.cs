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
    public class ProvinciaCAD
    {
        private ConexionCAD conexion;
        private ArrayList lista;
        private SqlCommand consulta;
        private SqlDataReader lector;


        //done
        public void creaProvincia(int codigo, string nombre)
        {
            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("insert into provincia values(" + codigo + "," + nombre + ")", conexion.Conectar());
                consulta.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                //TODO imprimir mensage donde toque
            }
            finally
            {
                conexion.Desconectar();
            }

        }


        //done
        // Select de la tabla Provincia
        public ArrayList leeTablaProvinciaCAD()
        {
            lista = new ArrayList();
            conexion = new ConexionCAD();

            try
            {
                // Conectamos
                conexion.Conectar();
                consulta = new SqlCommand("Select * from provincia", conexion.Conectar());
                // Leemos
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["nombre"].ToString());
                    // lista.Add(lector["codigo"].ToString());

                }
                // Cerramos lector
                lector.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                // Desconectamos
                conexion.Desconectar();
            }
            // Damos datos al EN
            return lista;
        }
        //done
        public ArrayList leeProvinciaPorCodigoCAD(int cod)
        {
            lista = new ArrayList();
            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from provincia where codigo = " + cod, conexion.Conectar());
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["nombre"].ToString());
                }
                lector.Close();
            }
            catch (Exception ex)
            {
            }

            finally
            {
                conexion.Desconectar();
            }

            return lista;
        }
        //done
        public ArrayList leeProvinciaPorNombreCAD(string nom)
        {
            lista = new ArrayList();

            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from provincia where nombre =" + nom, conexion.Conectar());
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["nombre"].ToString());
                }
                lector.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexion.Desconectar();
            }
            return lista;
        }
        //done
        public bool compruebaExisteProvinciaCAD(int codigo)
        {
            int total = 0;
            bool existe = false;
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("SELECT COUNT(*) FROM provincia WHERE codigo=" + codigo + ";", conexion.Conectar());
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

        //done
        // Update de Provincia
        public void modificaProvinciaCAD(int cod, string nom)
        {
            try
            {
                conexion = new ConexionCAD();
                //conecto
                conexion.Conectar();
                //introduzco la instruccion
                consulta = new SqlCommand("update provincia set nombre = '" + nom + "' where codigo =" + cod, conexion.Conectar());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }

            finally
            {
                conexion.Desconectar();
            }
        }
        //done
        // Delete de Provincia
        public void eliminaProvinciaCAD(int codigo)
        {
            try
            {
                conexion = new ConexionCAD();
                //conecto
                conexion.Conectar();
                //introduzco la instruccion
                consulta = new SqlCommand("Delete  from provincia where codigo = " + codigo, conexion.Conectar());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conexion.Desconectar();
            }

        }

      
    }
}
