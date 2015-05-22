//HECHO


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using TiendaVehiculos.CAD;
using System.Collections;

namespace TiendaVehiculos.EN
{
    public class UsuarioEN
    {
        private UsuarioCAD usuariocad;

        public class Usuario
        {
            // Propiedades de Usuario
            private string dni;
            private string email;
            private string tipo;
            private string nombre;
            private string apellido1;
            private string apellido2;
            private DateTime fecha_nacimiento;
            private DateTime fecha_alta;
            private string contrasenya;

            public string Dni
            {
                get { return dni; }
                set { dni = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Tipo
            {
                get { return tipo; }
                set { tipo = value; }
            }

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Apellido1
            {
                get { return apellido1; }
                set { apellido1 = value; }
            }

            public string Apellido2
            {
                get { return apellido2; }
                set { apellido2 = value; }
            }

            public DateTime Fecha_nac
            {
                get { return fecha_nacimiento; }
                set { fecha_nacimiento = value; }
            }

            public DateTime Fecha_alta
            {
                get { return fecha_alta; }
                set { fecha_alta = value; }
            }

            public string Contrasenya
            {
                get { return contrasenya; }
                set { contrasenya = value; }
            }
        }
        // Metodo que enviara al CAD los datos
        // del cliente, para verificarlos
        public bool compruebaUsuarioEN(string l, string p)
        {
            bool existe;
            usuariocad = new UsuarioCAD();
            // Creamos un cliente
            Usuario c = new Usuario();
            // Enviamos al CAD los datos
            existe = usuariocad.compruebaUsuarioCAD(l, p);

            return existe;
        }


        public ArrayList mostrarUsuarios()
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            lista = usuariocad.leeTablaUsuarioCAD();
            return lista;
        }
        public ArrayList mostrarUsuariosPorDNI(string dni)
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            lista = usuariocad.leeTablaUsuarioCADpordni(dni);
            return lista;
        }
        public ArrayList mostrarUsuariosPorNombre(string nombre, string apellido1, string apellido2)
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            lista = usuariocad.leeTablaUsuarioCADpornombre(nombre, apellido1, apellido2);
            return lista;
        }
        public ArrayList mostrarUsuariosPorFechaRegistro(DateTime fecha_alta)
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            lista = usuariocad.leeTablaUsuarioCADporFechadeAlta(fecha_alta);
            return lista;
        }
        public ArrayList mostrarAdmin(string log, string pass)
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            lista = usuariocad.leeAdminCAD(log, pass);
            return lista;
        }
        public void ModificarUsuarios(string dni, string email, string tipo, string nombre, string apellido1, string apellido2, DateTime fecha_nacimiento, DateTime fecha_alta, string contrasenya)
        {
            UsuarioCAD usuariocad = new UsuarioCAD();
            usuariocad.modificaUsuarioCAD(dni, email, tipo, nombre, apellido1, apellido2, fecha_nacimiento, fecha_alta, contrasenya);
        }
        public void EliminarUsuarios(string dni)
        {
            UsuarioCAD usuariocad = new UsuarioCAD();
            usuariocad.eliminaUsuarioCAD(dni);
        }
        public ArrayList leeUsuario(string log, string pass)
        {
            ArrayList lista = new ArrayList();
            UsuarioCAD usuariocad = new UsuarioCAD();
            usuariocad.leeUsuarioCAD(log, pass);
            return lista;
        }
        public bool comprobarUsuario(string log, string pass)
        {
            UsuarioCAD usuariocad = new UsuarioCAD();
            bool existe = false;
            if (usuariocad.compruebaUsuarioCAD(log, pass))
            {
                existe = true;
            }
            return existe;
        }
        public bool comprobarAdmin(string log, string pass)
        {
            UsuarioCAD usuariocad = new UsuarioCAD();
            bool existe = false;
            if (usuariocad.compruebaAdminCAD(log, pass))
            {
                existe = true;
            }
            return existe;
        }
        public void insertaUsuarioEN(string dni, string email, string nombre, string ap1, string ap2, string fechaNacimiento, string pass)
        {
            usuariocad = new UsuarioCAD();

            usuariocad.insertaUsuarioCAD(dni, email, nombre, ap1, ap2, fechaNacimiento, pass);
        }
    }
}
