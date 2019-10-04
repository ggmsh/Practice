using System;

namespace BASIC_PROGRAMING
{
    class Example1
    {
        public void funct()
        {
            Console.WriteLine("no argument function");
        }
        static void Main(string[] args)
        {
            Example1 ex = new Example1();
            ex.funct();
            Console.WriteLine("...program success");
        }
    }
}
