﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternTwelve
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for (int row = noOfrows; row >= 1; row--)
            { 
                for(int cols = 1; cols <=row; cols++)
                {
                    Console.Write(cols);
                }
                Console.WriteLine();
            }
        }
    }
}
