using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using TiendaVehiculos.CAD;

namespace TiendaVehiculos.EN
{
    public class ClientesEN
    {
        private string dni;
        private string email;
        private string password;
        private string nombre;
        private string apellidos;
        private int tipo_cliente;
        private string direccion;
        private DateTime fechaAlta;
        private string ciudad;
        private string codPostal;
        private string pais;

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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }        
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }        
        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }       
        public int Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        
        public string CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        private int idProvincia;
        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public ClientesEN(string dni, string password, string email, string nombre, string apellidos, string direccion, string ciudad, string codPostal, int idProvincia)
        {
            this.dni = dni;
            this.password = password;
            this.email = email;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaAlta = DateTime.Now;
            this.tipo_cliente = 1;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.codPostal = codPostal;
            this.idProvincia = idProvincia;
            this.pais = "España";
        }


        public void AgregarCliente() { }
        public static bool clienteesta() { return false; }
        public static ClientesEN clientelogueado() { return null; }
        public static bool clientyaregistrado() { return false; }
        public void modificarCliente() { }
        public void bajacuentaCliente() { }

    }
}
