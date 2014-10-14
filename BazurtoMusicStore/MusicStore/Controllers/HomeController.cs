using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Negocio;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {

        MusicStoreEntities storeDB = new MusicStoreEntities();
        
        public ActionResult Index()
        {
            return View();
        }

    }
}
