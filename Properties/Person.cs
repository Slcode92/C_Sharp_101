using System;

namespace Properties
{
    public class Person 
    {

        public string Name { get; set; }
        public string Username { get; set; }

        

        public DateTime Birthdate { get; private set; } //auto implemented property 

      
        
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


      
        
        public int Age 
        {
            get 
            {
                TimeSpan timeSpan = DateTime.Today - Birthdate;
                int years = timeSpan.Days / 365;
                return years;
            }       
        }
    
    }
}
