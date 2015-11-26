using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        public static List<Product> products = new List<Product>()
        {
            
            new Product
            {
                Id = 1,
                Name = "Pinar 19L",
                Price = (decimal) 10.0
            },
            new Product
            {
                Id = 2,
                Name = "Erikli 19L",
                Price = (decimal) 12.5
            },
       

        };


        public ActionResult Index()
        {

            return View(products);
        }

        public ActionResult NewProduct()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public ActionResult SaveProduct(Product product)
        {
            //Save the product
            products.Add(product);



            return View(product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}