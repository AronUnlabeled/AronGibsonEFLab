using System;
using System.Collections.Generic;
using System.Linq;

namespace AronGibsonEntityFrameworkLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDB();
            DisplayALLDB();
            DisplayStudentDB();
        }

        //public static void CreateDB() {
        //    List<Student> ourClass = new List<Student> {
        //        new Student("justin","Wyoming,MI","Baja Blast"),
        //        new Student("Matt","Flint,MI","Hot Wings"),
        //        new Student("Logan","Plymouth,MI","Funyuns"),
        //        new Student("Raston","Zeeland,MI","Vanilla Instant Pudding"),
        //        new Student("Yousif","Oak Park,MI","Deep Dish Pizza"),
        //        new Student("Yash","Detroit,MI","Hot Cheeto Puffs"),
        //        new Student("Chris","Novi","Tacos"),
        //        new Student("Radeen","Warren,MI","Mexican"),
        //        new Student("Josh","Northville","Naleśniki"),
        //        new Student("Kasean","Berea,KY","sushi"),
        //        new Student("Scott","Detroit,MI","steak"),
        //        new Student("Delmar","Detroit,MI","Nashville Chicken"),
        //        new Student("Brandon","Novi","vietnamese food")
        //    }; 

        //    using (ClassContext context = new ClassContext()) {
        //        foreach (Student s in ourClass)
        //            context.Students.Add(s);                   
        //        context.SaveChanges();
        //    }     
        //}

        public static void DisplayALLDB()
        {
            ClassContext context = new ClassContext();
            foreach (Student s  in context.Students)
            {
                Console.WriteLine($"{s.StudentID} {s.Name}");
            }
        }

        public static void DisplayStudentDB() {
            ClassContext context = new ClassContext();
            Console.WriteLine("Enter a student ID to learn about the student");
            int input = int.Parse(Console.ReadLine());
            Student result = context.Students.Where(x => x.StudentID == input).First();
            Console.WriteLine($"Name: {result.Name} Favorite Food: {result.HomeTown} Home town: {result.Food}");
        }

    }
}
