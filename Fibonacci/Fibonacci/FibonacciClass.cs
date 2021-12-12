using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class FibonacciClass
    {
        public int Num = 0;
        public int Num2 = 1;
        public void FibonacciCount(int num)
        {
            for (int i = 0; i < num ; i++)
            {
                Num2 += Num;
                Num = Num2 - Num;
                Console.WriteLine(Num);
            }
        }
    }
}
