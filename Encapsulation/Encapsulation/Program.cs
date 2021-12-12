using Encapsulation.Models;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Designer Hikmet = new Designer();
            Hikmet.PcModelProp = "5";
            Console.WriteLine(Hikmet.PcModelProp);
        }
    }
}
