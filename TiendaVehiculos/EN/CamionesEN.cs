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
    public class CamionesEN
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int stock;
        private float precio;
        private int plazas;
        private int destacado;
        private string imagen;
        private string motor;
        private int taraMax;
        private char claseRemolque;

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


        public int Plazas
        {
            get { return plazas; }
            set { plazas = value; }
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
        public int TaraMax
        {
            get { return taraMax; }
            set { taraMax = value; }
        }
        public char ClaseRemolque
        {
            get { return claseRemolque; }
            set { claseRemolque = value; }
        }


        public CamionesEN(int id, string nombre,
                            string descripcion, int stock,
                            float precio, int plazas, string imagen, int destacado, string motor)
        {

            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.plazas = plazas;
            this.destacado = destacado;
            this.imagen = imagen;
            this.motor = motor;
        }

        public CamionesEN()
        {

            id = 0;
            nombre = "";
            descripcion = "";
            stock = 0;
            precio = 0;
            plazas = 0;
            destacado = 0;
            imagen = "";

        }

        public static DataTable llenar() { return null; }
        public static DataTable producto() { return null; }
        public static CochesEN Datosarticulo() { return null; }
        public static DataTable Buscador() { return null; }
        public static DataTable Categorias() { return null; }

    }
}
