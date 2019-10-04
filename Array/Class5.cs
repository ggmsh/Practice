using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Example6
    {
        public static void multi(int[,] arr)
        {
            for (int i = 0; i < 3; i++) 
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Example6.multi(arr1);
        }
    }
}
