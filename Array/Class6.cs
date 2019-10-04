using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example7
    {
        public static void jagged(int[][] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j =0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[][] arr1 = new int[3][];
            arr1[0] = new int[] { 1, 2, 3, 4, 5 };
            arr1[1] = new int[] { 6, 7, 8, 9 };
            arr1[2] = new int[] { 10, 11, 12 };

            Example7.jagged(arr1);
        }
    }
}
