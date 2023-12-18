using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BanHang.Models;

namespace BanHang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int categoryId = 1)
        {
            CnCstoreEntities dBContext = new CnCstoreEntities();
            List<Product> Listproducts = dBContext.Products
                                        .Include(cat => cat.Category)
                                        .Where(pro => pro.CatId == categoryId).ToList();
            return View(Listproducts);
        }

        public ActionResult Details(int id)
        {
            CnCstoreEntities dBContext = new CnCstoreEntities();
            Product product = dBContext.Products.Include(cat => cat.Category).FirstOrDefault(x => x.ProId == id);
            return View(product);
        }

    }
}