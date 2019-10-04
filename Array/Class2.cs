// arra passing to function

using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{

    class Example3
    {
        public static void Afunct(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        

        static void Main(string[] args)
        {
            int[] arr1 = { 50, 20, 10, 12, 13, 25, 24 };
            int[] arr2 = { 80, 0, 90, 100, 110, 150, 202, 900 };

            Example3.Afunct(arr1);
            Console.WriteLine("next Array");
            Example3.Afunct(arr2);
        }
    }
}

