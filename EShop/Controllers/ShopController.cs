using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Controllers
{
    public class ShopController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}