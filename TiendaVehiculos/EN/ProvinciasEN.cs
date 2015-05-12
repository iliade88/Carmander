using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
//using Libreria.CAD;
using System.Collections;

namespace Libreria.EN
{
    class ProvinciasEN
    {
        private int id;
        private string provincia;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }


        public ArrayList ObtenerProvincias() { return null; }
        public void InsertarProvincia() { }
        public void BorrarProvincia(){}
        public void ModificarProvincia(){}
        public ProvinciasEN ObtenerProvinciaPorId(int id) { return null; }
        

    }
}
