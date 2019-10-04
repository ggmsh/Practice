// call by value

using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example5
    {
        static void funct(int num)
        {
            num *= num;
            Console.WriteLine("value inside function:" + num);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter value:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("given value:" + num);
            Example5.funct( num);
            Console.WriteLine("value after calling the function:" + num);

        }
    }
}
