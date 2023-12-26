using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bau_rasa.web.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public ActionResult Index()
        {
            ViewBag.Title = "Fotoğraflar";
            return View();
        }
    }
}