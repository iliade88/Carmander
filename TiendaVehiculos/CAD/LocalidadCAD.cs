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
    public class LocalidadCAD
    {
        private ConexionCAD conexion;
        private ArrayList lista;
        private SqlCommand consulta;
        private SqlDataReader lector;

        //done
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
        //done
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
        //done
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
        //done
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
        //done
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
        //done
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

        //done
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
        //done
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
