﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            
            foreach (char character in name)
            {

                Console.WriteLine(character);
            }

            //----------------------------------------------
            var numbers = new int[] {1,2,3,4};

            foreach (char number in numbers)
            {
                Console.WriteLine(number);
            }

            

        }
    }
}