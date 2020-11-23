using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public void Study()
        {
            Console.WriteLine($"{name} is studying");
        }
    }
}
