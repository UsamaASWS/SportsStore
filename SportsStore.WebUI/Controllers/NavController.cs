using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Abstract;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        //private IProductsRepository repository;
        //public NavController(IProductsRepository repo)
        //{
        //    repository = repo;
        //}
        //public PartialViewResult Menu2()
        //{
        //    IEnumerable<string> categories = repository.Products
        //    .Select(x => x.Category)
        //    .Distinct()
        //    .OrderBy(x => x);
        //    return PartialView(categories);
        //}
        private IProductsRepository repository;
        public NavController(IProductsRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);
            return PartialView(categories);
        }

    }
}



//public string Menu()
//        {
//            return "Hello from NavController";
//        }
//    }
//}