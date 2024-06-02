using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoc.Models
{
    public class Doctor : User
    {
        public int Specialization { get; set; }
        public int Contact { get; set; }
        public int Location { get; set; }
        public int Availability { get; set; }


    }
}
