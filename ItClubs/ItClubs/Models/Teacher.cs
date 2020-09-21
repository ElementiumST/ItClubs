using System;
using System.Collections.Generic;
using System.Text;

namespace ItClubs.Models
{
    class Teacher
    {
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String LastName { get; set; }
        public List<Group> groups { get; set; }
    }
}
