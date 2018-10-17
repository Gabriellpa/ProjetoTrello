using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDEMO.Models;


namespace WebApiDEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }
        
        [System.Web.Http.HttpGet]
        public ActionResult Modal()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public void PostCard([FromBody] Card card)
        {
            Card cardAqui = card;            
        }

    }
}
