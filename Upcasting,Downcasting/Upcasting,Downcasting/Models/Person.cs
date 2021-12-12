using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    public abstract class Person
    {
        public string Surname { get; set; }

        public abstract void Write();
        public virtual void Read()
        {
            Console.WriteLine("Person read a book");
        }
    }
}
