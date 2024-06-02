using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoc.Models
{
    public abstract class User : object
    {
        public int Id { get; set; }
        public string FirstAndLastName { get; set; }
        public string Specialization { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public string Availability { get; set; }
        public override string ToString()
        {
            return FirstAndLastName + " " + Specialization + " " + Contact + " " + Location + " " + Availability;
        }
    }

}
