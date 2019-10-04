using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example4
    {
        public static void MinNum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("min number is:" + min);
        }

            static void Main(string[] args)
            {
                int[] arr1 = { 10, 50, 100, 1, 54, 3 };
                Example4.MinNum(arr1);
            }
        }
    }


