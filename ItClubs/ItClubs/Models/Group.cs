using System;
using System.Collections.Generic;
using System.Text;

namespace ItClubs.Models
{
    class Group
    {
        public int Id { get; set; }
        public String GroupName { get; set; }
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }
        public List<Student> students {get; set;}
    }
}
