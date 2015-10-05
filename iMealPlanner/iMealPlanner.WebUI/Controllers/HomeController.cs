using iMealPlanner.Contracts.Repos;
using iMealPlanner.DAL.Data;
using iMealPlanner.DAL.Repos;
using iMealPlanner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMealPlanner.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Recipe> recipes;

        public HomeController(IRepositoryBase<Recipe> recipes)
        {
            this.recipes = recipes;
        }

        public ActionResult Index()
        {
            
            return View();
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