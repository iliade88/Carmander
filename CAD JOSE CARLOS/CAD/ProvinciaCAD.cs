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

        // CrearLocalidad
        public void creaLocalidadCAD(int codigo, string pueblo, int provincia)
        {
            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("insert into localidad values(" + codigo + "," + pueblo + "," + provincia + ")", conexion.Conectar());
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

        // Select de la tabla Localidad
        public ArrayList leeTablaLocalidadCAD()
        {
            lista = new ArrayList();
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from localidad", conexion.Conectar());
                // Leemos
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["pueblo"].ToString());
                    lista.Add(lector["provincia"].ToString());
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

        //Select localidad por codigo
        public ArrayList leeLocalidadPorCodigoCAD(int cod)
        {
            lista = new ArrayList();
            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from localidad where codigo = " + cod, conexion.Conectar());
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["pueblo"].ToString());
                    lista.Add(lector["provincia"].ToString());
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

        //Select localidad por pueblo
        public ArrayList leeLocalidadPorPuebloCAD(string pueblo)
        {
            lista = new ArrayList();

            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from localidad where nombre =" + pueblo, conexion.Conectar());
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["pueblo"].ToString());
                    lista.Add(lector["provincia"].ToString());
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

        //select localidad por Provincia
        public ArrayList leeLocalidadPorProvinciaCAD(int provincia)
        {
            lista = new ArrayList();

            try
            {
                conexion = new ConexionCAD();
                conexion.Conectar();
                consulta = new SqlCommand("Select * from localidad where provincia =" + provincia, conexion.Conectar());
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["pueblo"].ToString());
                    lista.Add(lector["provincia"].ToString());
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
        public ArrayList leeLocalidadProvinciaCAD()
        {
            lista = new ArrayList();
            conexion = new ConexionCAD();
            try
            {
                conexion.Conectar();
                consulta = new SqlCommand("Select Provincia.codigo, nombre, pueblo from Provincia,Localidad", conexion.Conectar());
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(lector["codigo"].ToString());
                    lista.Add(lector["nombre"].ToString());
                    lista.Add(lector["pueblo"].ToString());
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

        // Update de Localidad
        public void modificaLocalidadCAD(int cod, string pueblo, int provincia)
        {
            try
            {
                conexion = new ConexionCAD();
                //conecto
                conexion.Conectar();
                //introduzco la instruccion
                consulta = new SqlCommand("update set cod = " + cod + ", pueblo =" + pueblo + ", provincia=" + provincia + "where cod =" + cod, conexion.Conectar());
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

        // Delete de Localidad
        public void eliminaLocalidadCAD(int codigo, int codpro)
        {
            try
            {
                conexion = new ConexionCAD();
                //conecto
                conexion.Conectar();
                //introduzco la instruccion
                consulta = new SqlCommand("Delete  from localidad where codigo = " + codigo + "and provincia = " + codpro, conexion.Conectar());
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
