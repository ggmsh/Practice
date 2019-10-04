using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example3
    {
        public static void funct(int age)
        {
            if(age>=18)
            {
                Console.WriteLine(" eligible to vote");
            }else
            {
                Console.WriteLine("not eligible to vote");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Example3.funct(age);
        }
    }
}
