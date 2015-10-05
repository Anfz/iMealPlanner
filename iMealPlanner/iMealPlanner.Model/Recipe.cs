using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMealPlanner.Model
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Description { get; set; }

        public string RecipeUrl { get; set; }

        public string Instructions { get; set; }

        public string Notes { get; set; }
    }
}
