using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //display the even number from 1 -10

            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)   //if remainder ends in 0, then print (even numbers)
                {
                    Console.WriteLine(i);
                }
            }

                for (var i = 10; i >=1 ; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }

            /*

            1 % 2 will result in a 1. One divided by two results in 0 with a remainder of 1.
            2 % 2 will result in a 0. Two divided by two results in a 1 with a remainder of 0.
            3 % 2 will result in a 1. Three divided by two results in a 1 with a remainder of 1
            4 % 2 will result in a 0. Four divided by two results in a 2 with a remainder of 0.
            5 % 2 will result on a 1. Five divided by two results in a 2 with a remainder of 1.
            */
        }
        }
        }

