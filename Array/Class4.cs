// printing maximum number in array

using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example5
    {
        public static void MaxNum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("max number is:" + max);
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 10, 50, 100, 1, 54, 3 };
            Example5.MaxNum(arr1);
        }
    }
}
