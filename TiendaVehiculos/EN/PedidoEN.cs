using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
//using Libreria.CAD;

namespace Libreria.EN
{
    public class PedidoEN
    {
        private int id;
        private string id_cliente;
        private DateTime fecha;
        private int tipo_pago;
        private string direccion;
        private string ciudad;
        private string codPostal;
        private int idProvincia;
        private string pais;
        private float total;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Tipo_pago
        {
            get { return tipo_pago; }
            set { tipo_pago = value; }
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
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public PedidoEN(string id_cliente, string direccion, string ciudad, string codPostal, int idProvincia, string pais, float total)
        {
            this.id_cliente = id_cliente;
            this.direccion = direccion;
            this.fecha = DateTime.Now;
            this.tipo_pago = 1;
            this.ciudad = ciudad;
            this.codPostal = codPostal;
            this.idProvincia = idProvincia;
            this.pais = pais;
            this.total = total;
        }


        public void AgregarPedido() { }
    }
}
