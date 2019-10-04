using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example4
    {
        public static void funct(string name)
        {
            Console.Write("given name is :"+name);
            
            
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Example4.funct(name);
        }
        
    }
}
