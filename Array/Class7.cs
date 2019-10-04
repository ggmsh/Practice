using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example8
    {
        public static void param(params object[] arr)
        {
            for(int i = 0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Example8.param("gaurav", "hello", 1, 2, 2.5, "hey");
        }
    }
}
