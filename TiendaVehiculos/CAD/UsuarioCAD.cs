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

    

    class UsuarioCAD
    {
        private ConexionCAD conexion;
        private SqlCommand consulta;
        private SqlDataReader lector;
        private ArrayList lista;

        public ArrayList leeTablaUsuarioCAD()
        {
            lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            //hacemos la consulta
            consulta = new SqlCommand("SELECT*FROM usuario", conexion.Conectar());
            // Leemos
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["tipo"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["fecha_nacimiento"].ToString());
                lista.Add(lector["fecha_alta"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            // Cerramos lector
            lector.Close();
            // Desconectamos
            conexion.Desconectar();
            // Damos datos al EN
            return lista;
        }

        public ArrayList leeTablaUsuarioCADpordni(string dni)
        {
            lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            //hacemos la consulta
            consulta = new SqlCommand("SELECT*FROM usuario where dni = " + dni, conexion.Conectar());
            // Leemos
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["tipo"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["fecha_nacimiento"].ToString());
                lista.Add(lector["fecha_alta"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            lector.Close();

            // Cerramos lector

            // Desconectamos
            conexion.Desconectar();

            return lista;
        }

        public ArrayList leeTablaUsuarioCADpornombre(string nombre, string apellido1, string apellido2)
        {
            lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            //hacemos la consulta
            consulta = new SqlCommand("SELECT*FROM usuario where nombre = " + nombre + "and apellido1 =" + apellido1 + "and apellido2 =" + apellido2, conexion.Conectar());
            // Leemos
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["tipo"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["fecha_nacimiento"].ToString());
                lista.Add(lector["fecha_alta"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            lector.Close();

            // Cerramos lector

            // Desconectamos
            conexion.Desconectar();

            return lista;
        }

        public ArrayList leeTablaUsuarioCADporFechadeAlta(DateTime fecha_alta)
        {
            lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            //hacemos la consulta
            consulta = new SqlCommand("SELECT*FROM usuario where fecha_alta = " + fecha_alta, conexion.Conectar());
            // Leemos
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["tipo"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["fecha_nacimiento"].ToString());
                lista.Add(lector["fecha_alta"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            lector.Close();

            // Cerramos lector

            // Desconectamos
            conexion.Desconectar();

            return lista;
        }

        public ArrayList leeAdminCAD(string log, string pass)
        {
            ArrayList lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            // Creamos la query
            consulta = new SqlCommand("SELECT * FROM usuario WHERE tipo = 'ADMIN' AND email = '" + log + "' AND contrasenya = '" + pass + "';", conexion.Conectar());
            // Lanzamos la query
            lector = consulta.ExecuteReader();
            // Leemos los datos
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            // Subimos los datos a la capa de EN
            return lista;
        }

        // Update de Cliente
        public void modificaUsuarioCAD(string dni,string email, string tipo, string nombre, string apellido1, string apellido2, DateTime fecha_nacimiento, DateTime fecha_alta, string contrasenya)
        {
            conexion = new ConexionCAD();
            conexion.Conectar();
            consulta = new SqlCommand("update usuario set dni =" + dni + ",email =" + email + ",tipo=" + tipo + ",nombre =" + nombre + ",apellido1 = " + apellido1 + ",apellido2=" + apellido2 + ",fecha_nac = " + fecha_nacimiento + ",fecha_alta =" + fecha_alta + ",contrasenya=" + contrasenya + "where dni =" + dni);
            conexion.Desconectar();
        }

        // Delete de Cliente
        public void eliminaUsuarioCAD(string dni)
        {
            conexion = new ConexionCAD();
            conexion.Conectar();
            consulta = new SqlCommand("delete from usuario where=" + dni, conexion.Conectar());
            conexion.Desconectar();

        }

        public ArrayList leeUsuarioCAD(string log, string pass)
        {
            ArrayList lista = new ArrayList();
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            // Creamos la query
            consulta = new SqlCommand("SELECT * FROM USUARIO WHERE tipo = 'cliente' AND email = '" + log + "' AND contrasenya = '" + pass + "';", conexion.Conectar());
            // Lanzamos la query
            lector = consulta.ExecuteReader();
            // Leemos los datos
            while (lector.Read())
            {
                lista.Add(lector["dni"].ToString());
                lista.Add(lector["email"].ToString());
                lista.Add(lector["nombre"].ToString());
                lista.Add(lector["apellido1"].ToString());
                lista.Add(lector["apellido2"].ToString());
                lista.Add(lector["contrasenya"].ToString());
            }
            // Subimos los datos a la capa de EN
            return lista;
        }


        //Comprueba si hay un usuario con esos datos
        public bool compruebaUsuarioCAD(string log, string pass)
        {
            bool existe = false;
            int count = 0;
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            // Creamos la query
            consulta = new SqlCommand("SELECT COUNT(*) FROM USUARIO WHERE tipo = 'cliente' AND email = '" + log + "' AND contrasenya = '" + pass + "';", conexion.Conectar());
            // Lanzamos la query
            count = Convert.ToInt32(consulta.ExecuteScalar());
            // Hay un usuario con ese log y pass
            if (count > 0)
            {
                existe = true;
            }

            return existe;
        }
        //Comprueba si hay un admin con esos datos
        public bool compruebaAdminCAD(string log, string pass)
        {
            bool existe = false;
            int count = 0;
            // Conectamos
            conexion = new ConexionCAD();
            conexion.Conectar();
            // Creamos la query
            consulta = new SqlCommand("SELECT COUNT(*) FROM usuario WHERE tipo = 'admin' AND email = '" + log + "' AND contrasenya = '" + pass + "';", conexion.Conectar());
            // Lanzamos la query
            count = Convert.ToInt32(consulta.ExecuteScalar());
            // Hay un admin con ese log y pass
            if (count > 0)
            {
                existe = true;
            }

            return existe;
        }

        //inserta un usuario
        public bool insertaUsuarioCAD(string dni, string email, string nombre, string ap1, string ap2, string fechaNacimiento, string pass1)
        {
            bool insertado = false;
            try
            {
                // Conectamos
                conexion = new ConexionCAD();
                conexion.Conectar();
                // Creamos la query
                consulta = new SqlCommand("INSERT INTO usuario VALUES('" + dni + "','" + email + "','cliente','" + nombre + "','" + ap1 + "','" + ap2 + "', '" + fechaNacimiento + "', GETDATE(), '" + pass1 + "')", conexion.Conectar());
                // Lanzamos la query
                consulta.ExecuteNonQuery();
                insertado = true;
            }
            catch (Exception e)
            {
                insertado = false;
            }
            finally
            {
                conexion.Desconectar();
            }
            return insertado;
        }
    }
}
