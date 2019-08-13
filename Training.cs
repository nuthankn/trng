using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_TrngMgmt
{
   public class Training
    {
        public string TrngID { get; set; }
        public string Title { get; set; }
        public List<Course> Courses { get; set; }
    }
}
