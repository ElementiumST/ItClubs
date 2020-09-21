using System;
using System.Collections.Generic;
using System.Text;

namespace ItClubs.Models
{
    class Student
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String LastName { get; set; }
        public int GroupID { get; set; }
        public Group Group{ get; set; }
    }
}
