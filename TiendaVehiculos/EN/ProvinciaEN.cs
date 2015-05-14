
// HECHO!

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
    public class ProvinciasEN
    {
        
        private ProvinciaCAD Provinciacad;


        public ArrayList ObtenerProvincias() {
            ArrayList lista = new ArrayList();
            Provinciacad = new ProvinciaCAD();
            lista = Provinciacad.leeTablaProvinciaCAD();
            return lista;
        }
        public void InsertarProvincia(int codigo, string nombre) {
            Provinciacad = new ProvinciaCAD();
            Provinciacad.creaProvincia(codigo,nombre);
        }
        public void BorrarProvincia(int codigo){
            Provinciacad = new ProvinciaCAD();
            Provinciacad.eliminaProvinciaCAD(codigo);
        }
        public void ModificarProvincia(int codigo, string nombre) {
            Provinciacad = new ProvinciaCAD();
            Provinciacad.modificaProvinciaCAD(codigo,nombre);
        }
        public ArrayList ObtenerProvinciaPorCodigo(int codigo) {
            ArrayList lista = new ArrayList();
            Provinciacad = new ProvinciaCAD();
            lista = Provinciacad.leeProvinciaPorCodigoCAD(codigo);
            return lista;
        }
        public ArrayList ObtenerProvinciaPorNombre(string nom)
        {
            ArrayList lista = new ArrayList();
            Provinciacad = new ProvinciaCAD();
            lista = Provinciacad.leeProvinciaPorNombreCAD(nom);
            return lista;
        }
        public bool ExisteProvincia(int cod)
        {
            bool sino = false;
            Provinciacad = new ProvinciaCAD();
            if (Provinciacad.compruebaExisteProvinciaCAD(cod))
            {
                sino = true;
            }
            return sino;
        }

        

    }
}
