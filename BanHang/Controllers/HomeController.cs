using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanHang.Models;

namespace BanHang.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CnCstoreEntities dBContext = new CnCstoreEntities();
            var Listproducts = dBContext.Product_Category;
            return View(Listproducts);
        }
    }
}