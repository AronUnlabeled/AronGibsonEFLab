using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AronGibsonEntityFrameworkLab
{
    class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Food { get; set; }
        public string HomeTown { get; set; }

        public Student(string Name, string HomeTown, string Food) {
            this.Name = Name;
            this.Food = Food;
            this.HomeTown = HomeTown;
        }

    }
}
