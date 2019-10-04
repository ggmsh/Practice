// using foreach loop

using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example2
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 47, 52, 54, 62 };

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
