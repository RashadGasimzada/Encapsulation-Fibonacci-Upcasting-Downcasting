using System;
using Upcasting_Downcasting.Models;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting
            //Student student1 = new Student();
            //Person person1 = student1;
            //person1.Read();


            //Person[] People = { student1, person1 };
            //foreach (var item in People)
            //{
            //    item.Read();
            //}
            #endregion
            #region Downcasting
            //Person person2 = new Student();
            //Student student2 = (Student)person2;
            //string str = "You make me crazy";
            //object[] objects = { 5, str, student2, person2 };
            //foreach (var item in objects)
            //{
            //    //Student student = item as Student;
            //    //if (student != null)
            //    //{
            //    //    ((Student)item).Age = 18;
            //    //    Console.WriteLine(((Student)item).Age);
            //    //}
            //    if (item is Student e)
            //    {
            //        e.Age = 27;
            //        Console.WriteLine(e.Age);
            //    }
            //}
            #endregion
        }
    }
}
