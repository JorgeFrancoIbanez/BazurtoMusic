using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Negocio
{
    public abstract class Cancion
    {
        #region "atributos"
        string idCancion;

        
        string nombreCancion;
        int precio;
        TimeSpan span = new TimeSpan();
        int calidad;
        int tamaño;
        #endregion



        #region "propiedades"

        public string IdCancion
        {
            get { return idCancion; }
            set { idCancion = value; }
        }
        
        public string NombreCancion
        {
          get { return nombreCancion; }
          set { nombreCancion = value; }
        }
     

        public int Precio
        {
          get { return precio; }
          set { precio = value; }
        }
       

        public TimeSpan Span
        {
          get { return span; }
          set { span = value; }
        }
      

        public int Calidad
        {
          get { return calidad; }
          set { calidad = value; }
        }
     

        public int Tamaño
        {
          get { return tamaño; }
          set { tamaño = value; }
        }
    #endregion


        #region "constructores"
        public Cancion()
        {
            this.idCancion = "N/A";
            this.nombreCancion = "N/A";
            this.precio= 0;
            this.span = new TimeSpan(0,0,0);
            this.calidad = 0;
            this.tamaño = 0;
        }

        public Cancion(string idCancion, string nombreCancion, int precio, int calidad, int tamaño, TimeSpan span = new TimeSpan())
        {
            this.idCancion = idCancion;
            this.nombreCancion = nombreCancion;
            this.precio = precio;
            this.span = span;
            this.calidad = calidad;
            this.tamaño = tamaño;


        #endregion
        }


    }
}
