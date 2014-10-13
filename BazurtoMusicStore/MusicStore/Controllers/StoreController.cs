using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Negocio;


namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        //para la busqueda en la base de datos, llama a toda la informacion.
        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index() 
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }


        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id};
            return View(album);
        }
    }
}
