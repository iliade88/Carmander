using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TiendaVehiculos.CAD;

namespace TiendaVehiculos.EN
{
    public class MotosEN
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int stock;
        private float precio;
        private int destacado;
        private string imagen;
        private string motor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }




        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Destacado
        {
            get { return destacado; }
            set { destacado = value; }
        }


        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public MotosEN(int id, string nombre,
                            string descripcion, int stock,
                            float precio, int plazas, string imagen, int destacado, string motor)
        {

            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.destacado = destacado;
            this.imagen = imagen;
            this.motor = motor;
        }

        public MotosEN()
        {

            id = 0;
            nombre = "";
            descripcion = "";
            stock = 0;
            precio = 0;
            destacado = 0;
            imagen = "";

        }
        /*
        public static DataTable llenar() {
            
        }

        public static DataTable producto(int id) {
            
        }

        public static CochesEN Datosarticulo(int id) {
            
        }

        public static DataTable Buscador(string bus) {
            
        }

        public static DataTable Categorias(int tp, int so) {
            
        }*/

    }
}
