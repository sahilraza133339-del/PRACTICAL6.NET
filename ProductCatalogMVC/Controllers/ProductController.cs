using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductCatalogMVC.Models;

namespace ProductCatalogMVC.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000, Category = "Electronics" },
            new Product { Id = 2, Name = "Mobile", Price = 25000, Category = "Electronics" },
            new Product { Id = 3, Name = "Headphones", Price = 2000, Category = "Accessories" }
        };

        public ActionResult Index()
        {
            return View(Products);
        }

        public ActionResult Details(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}
