// call by reference

using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example6
    {
        public static void funct(ref int num)
        {
            num *= num;
            Console.WriteLine("value inside the fuction:" + num);
           
        }
        static void Main(string[] args)
        {
            Console.Write("Enter value:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("given value:" + num);
            Example6.funct(ref num);
            Console.WriteLine("value after calling the function:" + num);
        }
    }
}
