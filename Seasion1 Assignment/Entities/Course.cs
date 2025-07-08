using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasion1_Assignment.Entities
{
    internal class Course
    {
        public int CrId { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
