﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_And_Lamda
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
                int[] fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
                double averageValue = fibNum.Where(num => num % 2 == 1).Average();
                Console.WriteLine(averageValue);
                Console.ReadLine();
            }
        }
    
}
    
