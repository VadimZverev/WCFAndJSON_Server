using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFAndJSON_Client.Models;

namespace WCFAndJSON_Client.Controllers
{
    public class ProductController : Controller
    {   
        public ActionResult Index()
        {
            ProductServicClient psc = new ProductServicClient();
            ViewBag.Product = psc.Find();
            ViewBag.ListProduct = psc.FindAll();

            return View();
        }
    }
}