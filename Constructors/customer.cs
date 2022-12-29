using System.Globalization;
using System.Collections.Generic;


namespace Constructors
{
    public class Customer 
    {
        public int Id;
        public string Name;
        public List<Order> Orders;//takes objects in order class as parameter - list called "Orders"
         


      
        public Customer() //default and parameterless constructor
        { 
            Orders = new List<Order>();
        }


        public Customer(int id) //inserted 1  parameter 
            :this()//this is going to call the contructor without params 1st -- the one above 
        {
            this.Id = id;
            
        }

        public Customer(int id, string name) //inserted parameter
            :this(id)
        {
            this.Name = name;

        }
    }
}
