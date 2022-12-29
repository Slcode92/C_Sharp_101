using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1,2,3,4};
            

            numbers.Add(1); //add one object to the end of the list 
            
            numbers.AddRange(new int[3]{ 5,6,7 });    //add array to list

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.IndexOf(1); //returns the index of given object

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count " + numbers.Count); //returns numbers of objects in list

            numbers.Remove(1);  //removes the first 1 

            foreach (var number in numbers)
                Console.WriteLine(number);

            //What if you want to remove all the 1ns ?

            for (var i = 0; i<numbers.Count;i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);


            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
