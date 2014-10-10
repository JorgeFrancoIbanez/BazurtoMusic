using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Negocio
{
    public class Venta : Catalogo
    {
        Album album = new Album();

        public Album Album
        {
            get { return album; }
            set { album = value; }
        }

        string idVenta;

        public string IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }


    }
}