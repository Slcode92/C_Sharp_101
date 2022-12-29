using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1); //Created date Jan 1st 2015
            var now = DateTime.Now; // Get the current date time
            var today= DateTime.Today; //Get todays date 
            
            
         //   Console.WriteLine("Hour : " + now.Hour);//call the hour 
          //  Console.WriteLine("Minute : " + now.Minute);//call the minute 

            //once you create them, you cant change them

            var tommorow = now.AddDays(1); //adds on day to current time 
            var yesterday = now.AddDays(-1);
            


            //formatting Date/Time to a string 
            Console.WriteLine(now.ToLongDateString());  //displays date only  --- 27 Feburary 2020
            Console.WriteLine(now.ToShortDateString()); // displays date  only ---27/02/2020
            Console.WriteLine(now.ToLongTimeString());  //displays time with milliseconds 
            Console.WriteLine(now.ToShortTimeString()); // displays time with no millioseconds



            //if you want to display both date and time 
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));



        }
    }
}
