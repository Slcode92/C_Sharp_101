using System.Collections.Generic;

namespace Fields
{
    public class Customer 
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); //no matter what constructor is used the orders field will be called on a empty list 
        
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id) // takes previous constructor 
        {
            this.Name = name; 
        }

   
        public void Promote() 
        {
            
            //...
        }


    }
}
