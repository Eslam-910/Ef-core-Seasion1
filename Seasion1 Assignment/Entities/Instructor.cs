using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasion1_Assignment.Entities
{
    internal class Instructor
    {
        public int Ins_Id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public DateTime HourRate { get; set; }
    }
}
