﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter integer number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of the number is : {0}", Math.Sqrt(x));
        }
    }
}
