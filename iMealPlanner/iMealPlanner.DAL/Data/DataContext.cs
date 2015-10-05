using iMealPlanner.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMealPlanner.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        ///<summary>
        /// any entity to be persisted must  be declared here
        /// </summary>
        
        public DbSet<Recipe> Recipes { get; set; }
    }
}
