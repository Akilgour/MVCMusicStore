using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //http://www.asp.net/mvc/tutorials/mvc-music-store/mvc-music-store-part-2

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
    }
}
