using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC_PROGRAMING
{
    class Example7
    {
        public static void funct(out int b, out int c)
        {
            int a = 5;
            b = a;
            c = a;

            b *= b;
            c *= c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num1 and num2:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value of before using out parameter:" + num1 + " " + num2);
            Example7.funct(out num1, out num2);
            Console.WriteLine("value of after using out parameter:" + num1+" "+num2);
        }

            
        }

    }

