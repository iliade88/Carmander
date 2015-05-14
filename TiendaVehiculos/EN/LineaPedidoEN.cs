using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using TiendaVehiculos.CAD;

namespace TiendaVehiculos.EN
{
    public class LineaPedidoEN
    {
        private int id;
        private int id_articulo;
        private int id_pedido;
        private float precio_Unidad;
        private int cantidad;
        private float total;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }     
        public int Id_articulo
        {
            get { return id_articulo; }
            set { id_articulo = value; }
        }
        public int Id_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        public float Precio_Unidad
        {
            get { return precio_Unidad; }
            set { precio_Unidad = value; }
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

        public LineaPedidoEN(int id_articulo, int id_pedido, float precio_Unidad, int cantidad, float total)
        {
            this.id_articulo = id_articulo;
            this.id_pedido = id_pedido;
            this.precio_Unidad = precio_Unidad;
            this.cantidad = cantidad;
            this.total = total;

        }

        public void AgregarLineaPedido(){}

    }
}
