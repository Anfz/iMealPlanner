using iMealPlanner.DAL.Data;
using iMealPlanner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMealPlanner.DAL.Repos
{
    public class CodeRepository : RepositoryBase<Code>
    {
        public CodeRepository(DataContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
