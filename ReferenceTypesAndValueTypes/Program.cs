using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Value types 
            var a = 10;
            var b = a;

            b++;


            /*
             WHAT IS THE VALUE OF A?
             * answer will 10- a because value type takes a copy of that value 
             to a another variable, a copy of that value is taken and stored in the
             target location in memory 

            value types - there values are copied, two variabes are completely different
            making a change to one does not impact the other 
              
             */

            Console.WriteLine(string.Format("a: {0}, b:{1}", a,b) );



            //Reference Types 

            var array1 = new int [3] { 1, 2, 3 };

            var array2 = array1;

            //making a modification to array2 

            array2[0] = 0;

            Console.WriteLine(array1[0]);
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //answer will be 0 because its a reference type 

        }
            
    }
}
