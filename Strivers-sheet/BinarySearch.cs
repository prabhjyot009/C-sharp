﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,1, 2, 3, 4, 5 };
            int x = 2;
            Console.WriteLine(search(arr, x));
        }
        static int search(int[] arr, int x)
        {
            int start = 0;
            int freq = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == x)
                {
                    freq += mid;
                    return freq;
                }
                else if (x < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
