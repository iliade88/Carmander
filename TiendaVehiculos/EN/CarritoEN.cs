using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TiendaVehiculos.CAD;
using System.Collections;

namespace TiendaVehiculos.EN
{
    public class CarritoEN
    {
        private int id;
        private int idArticulo;
        private string nombre;
        private float precio;
        private int cantidad;
        private float total;
        private string imagen;
        private string cliente;
        private int descuento;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        } 
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public int Descuento {
            get {return descuento; }
            set { descuento = value; }
        }

        public CarritoEN(string usuario)
        {
            this.cliente = usuario;
        }
        public CarritoEN(int idArticulo, string nombre, float precio, int cantidad, float total, string imagen, string cliente, int descuento)
        {
            this.idArticulo = idArticulo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.total = total;
            this.imagen = imagen;
            this.cliente = cliente;
            this.descuento = descuento;
        }

        public ArrayList LeerCarrito()
        {
            CarritoCAD cad = new CarritoCAD();
            return cad.leerCarritoCAD(cliente);
        }
        public void AgregarCarrito() { }
        public static DataTable Llenar() { return null; }
        public static float CalcularTotal(){return 0;}
        public static bool Articuloesta(){return false;}     
        public static void obtenerarticulo(){}      
        public static void Editararticulo(){}
        public static void Borrararticulo(){}
              
    }
}
