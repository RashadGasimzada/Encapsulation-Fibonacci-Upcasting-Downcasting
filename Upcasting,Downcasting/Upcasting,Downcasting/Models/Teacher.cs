using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    public class Teacher:Person
    {
        public override void Write()
        {
            Console.WriteLine("Teacher write a letter");
        }
        public override void Read()
        {
            Console.WriteLine("Teacher read a book");
        }
    }
}
