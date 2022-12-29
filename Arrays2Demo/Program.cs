using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //length - how many elememts in array 

            Console.WriteLine("length " + numbers.Length);

            
            //IndexOf() - find the position of element of array 

            var index = Array.IndexOf(numbers, 9); //find number 9 in arra 
            Console.WriteLine("index of 9 : =  " + index);


            //Clear()- first two items are set to clear -"0", clear means setting to 0
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers )
                Console.WriteLine(n);

            //Copy() - copy one array to another 
            int[] another = new int [3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers); 
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            

        }
    }
}
