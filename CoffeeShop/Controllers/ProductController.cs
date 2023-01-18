using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repo;

        public ProductController()
        {
            repo = new ProductRepository();
        }

        
        public ActionResult List()
        {
            return View(repo.GetMockProducts());
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductViewModel product = repo.GetMockProducts().FirstOrDefault(x => x.Id == id);
            return View(product);
        }






        // attempt at extra credit got it to list the categories but once you click the category it would not display the items in that category
        public ActionResult CategoryList()
        {
            return View(repo.GetMockProducts());
        }

        public ActionResult Category(string id)
        {
            ProductViewModel category =repo.GetMockProducts().FirstOrDefault(x => x.Category == id);
            return View(category);
        }


     
        
     


 
    }
}