using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums

{

    //normally enum are ints 
    public enum ShippingMethod

    {

        RegularAirMail =1,
        RegisteredAirMail=2,
        Express=3

    } 


    class Program
    {
        static void Main(string[] args)
        {

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method );
            

            //imagine you recieved the number 3 from somewhere else (3rd party)
            //and want to convert that to shipping method (enum)

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);


            //Get a enum and convert it to a string 
            Console.WriteLine(method.ToString());
            Console.WriteLine(method);

            




            //get a string and convert it to a enum "methodName"
            //parsing - getting a string and coverting that to different type 
            //i want to parse a string to a shipping method use "Enum.Parse"


            //casted to enum 
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


            Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);

            

        }
    }
}
