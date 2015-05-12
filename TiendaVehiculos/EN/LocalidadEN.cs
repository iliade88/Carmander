
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
    class LocalidadEN
    {
        private int id;
        private LocalidadCAD Localidadcad;

        public void nuevaLocalidad(int codigo, string pueblo, int provincia)
        {
            Localidadcad = new LocalidadCAD();
            Localidadcad.creaLocalidadCAD(codigo,pueblo,provincia);
        }
        public ArrayList Mostrarlocalidades() {
            ArrayList lista = new ArrayList();
             Localidadcad = new LocalidadCAD();
             lista = Localidadcad.leeTablaLocalidadCAD();
            return lista;
        }
        public ArrayList Mostrarlocalidadesporcod(int cod) {
            ArrayList lista = new ArrayList();
            Localidadcad = new LocalidadCAD();
            lista = Localidadcad.leeLocalidadPorCodigoCAD(cod);
            return lista;
        }
        public ArrayList Mostrarlocalidadesporpueblo(string pueblo)
        {
            ArrayList lista = new ArrayList();
            Localidadcad = new LocalidadCAD();
            lista = Localidadcad.leeLocalidadPorPuebloCAD(pueblo);
            return lista;
        }
        public void modificarlocalidad(int codigo, string pueblo, int provincia)
        {
            Localidadcad = new LocalidadCAD();
            Localidadcad.modificaLocalidadCAD(codigo, pueblo, provincia);
        }
        public void eliminarmodificar(int codigo,int provincia)
        {
            Localidadcad = new LocalidadCAD();
            Localidadcad.eliminaLocalidadCAD(codigo, provincia);
        }
        public ArrayList mostrarporprovincia(int provincia)
        {
            ArrayList lista = new ArrayList();
            Localidadcad = new LocalidadCAD();
            lista = Localidadcad.leeLocalidadPorProvinciaCAD(provincia);
            return lista;
        }
        public ArrayList provinciadelocalidad()
        {
            ArrayList lista = new ArrayList();
            Localidadcad = new LocalidadCAD();
            lista = Localidadcad.leeLocalidadProvinciaCAD();
            return lista;
        }
 
    }
}
