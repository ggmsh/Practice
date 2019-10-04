using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example2
    {
        public void funct(int i)
        {
            Console.WriteLine("function with parameter");
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Example2 ex = new Example2();
            ex.funct(10);
            Console.WriteLine("...Success");
        }
    }
}
