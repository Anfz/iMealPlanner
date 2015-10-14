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
            var recipeList = recipes.GetAll();
            return View(recipeList);
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


        public ActionResult RecipeList()
        {
            var model = recipes.GetAll();

            return View(model);
        }

        public ActionResult CreateRecipe()
        {
            var model = new Recipe();

            return View(model);
        }


        [HttpPost]
        public ActionResult CreateRecipe(Recipe recipe)
        {

            recipes.Insert(recipe);
            recipes.Commit();

            return RedirectToAction("RecipeList");
        }

        public ActionResult EditRecipe(int id)
        {
            Recipe recipe = recipes.GetById(id);


            return View(recipe);
        }

        [HttpPost]
        public ActionResult EditRecipe(Recipe recipe)
        {
            recipes.Update(recipe);
            recipes.Commit();

            return RedirectToAction("RecipeList");
        }



    }
}