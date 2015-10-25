using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMealPlanner.Model
{
    public class Code
    {
        public int codeId { get; set; }
        public string Ref { get; set; }
        public string Description { get; set; }
        public string parentCodeId { get; set; }

    }
}
