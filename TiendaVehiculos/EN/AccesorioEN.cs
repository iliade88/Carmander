using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Libreria.CAD;


namespace Libreria.EN
{
    class AccesorioEN
    {
        private bool bolar_remolque;
        private bool porta_bicis;
        private bool GPS;
        private bool luces_diurnas;
        private bool sensor_parking;
        private bool techos_solar;
        private bool deportivo;
        private bool climatizador;
        private bool ambientadordepino;

        public bool Bola_remolque {
            get { return bolar_remolque;}
            set { bolar_remolque = value; }
        }
        public bool Porta_bicis
        {
            get { return porta_bicis; }
            set { porta_bicis = value; }
        }

        public bool GGPS {
            get { return GPS; }
            set { GPS = value; }
        }

        public bool Luces_diurnas {
            get { return luces_diurnas;}
            set { luces_diurnas = value; }
        }
        public bool Sensor_parking{
            get{return sensor_parking;}
            set{sensor_parking=value;}
        }

        public bool Techos_solar{
            get{return techos_solar;}
            set{techos_solar=value;}
        }
        public bool Deportivo{
            get { return deportivo; }
            set { deportivo = value; }
        }
        public bool Climatizador{
            get { return climatizador; }
            set { climatizador = value; }
        }
        public bool Ambientadordepino {
            get { return ambientadordepino; }
            set { climatizador = value; }
        }
        public AccesorioEN( bool bolar_remolque, bool porta_bicis, bool GPS, bool luces_diurnas, bool sensor_parking,
                            bool techos_solar, bool deportivo, bool climatizador, bool ambientadordepino){

                                this.bolar_remolque = bolar_remolque;
                                this.porta_bicis=  porta_bicis;
                                this.GPS = GPS;
                                this.luces_diurnas = luces_diurnas;
                                this.sensor_parking = sensor_parking;
                                this.techos_solar = techos_solar;
                                this.deportivo = deportivo;
                                this.climatizador = climatizador;
                                this.ambientadordepino = ambientadordepino;        
    }

        public AccesorioEN(){
            bolar_remolque=false;
            porta_bicis = false;
            GPS = false;
            luces_diurnas = false;
            sensor_parking = false;
            techos_solar = false;
            deportivo = false;
            climatizador = false;
            ambientadordepino = false;    
    }
        public static DataTable escoger() { return null; }
        public static DataTable producto() { return null; }
        public static CochesEN Datosarticulo() { return null; }
        public static DataTable Buscador() { return null; }
        public static DataTable Categorias() { return null; }

    }
}
