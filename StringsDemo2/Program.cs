using System;
namespace StringsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Suraj Lal ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            // Trims whitespace from begining and end 

            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            //find index, then split string into 2 parts 
            var index = fullName.IndexOf(' '); //looks for space in fullName
            Console.WriteLine( "index of:  "+index); //answer = 5- searching for space

            
            var firstName = fullName.Substring(0,index);
            //start from index from the index of space ' ', so index--variable

                        
            var lastName = fullName.Substring(index + 1);
            // After space (index-variable) ---till end of string

            Console.WriteLine("Substring FirstName: " + firstName);
            Console.WriteLine("Substring LastName: " + lastName);
            
            //easier way is to use split method 
            var names = fullName.Split(' '); 
            //You can supply a character or string here, stored in string array "names"
            Console.WriteLine("Split method FirstName: " + names[0]);
            Console.WriteLine("Split Method LastName: " + names[1]);


            //replace method
            ///will return new string, because strings are immutable 
            Console.WriteLine(fullName.Replace("Suraj", "Anil"));
            

            //METHODS TO WORK WITH EMPTY STRINGS OR NULLS 
            if(String.IsNullOrWhiteSpace(" "))//passed space as arg in if statment 
                Console.WriteLine("Invalid");

            //Convert string to number
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            //convert number to string 
            //to string method is a object method 
            //supplying a format string 
            float price = 29.95f;
            price.ToString(price.ToString("C0"));
        }
    }
}
