﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SecondSmallestAndLargest
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void secondLargeSmall(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = i; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            printArray(arr);
            Console.WriteLine("Second smallest"+arr[1]+"\nSecond largest" + arr[arr.Length-2]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 4,3,2,9,8};
            Console.Write("Given array: ");
            printArray(arr);
            secondLargeSmall(arr);
        }
    }
}
