using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    public class Student:Person
    {
        public int Age { get; set; }
        public override void Write()
        {
            Console.WriteLine("Student write a letter");
        }
        public override void Read()
        {
            Console.WriteLine("Student read a book");
        }
    }
}
