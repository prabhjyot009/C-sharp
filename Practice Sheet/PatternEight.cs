﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternEight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for(int rows = noOfrows; rows >= 1; rows--)
            {
                for(int cols = rows; cols >=1; cols--)
                {
                    Console.Write(cols);
                }
                Console.WriteLine();
            }
        }
    }
}
