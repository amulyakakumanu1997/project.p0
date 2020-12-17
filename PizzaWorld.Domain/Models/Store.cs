using System.Collections.Generic;

namespace PizzaWorld.Domain.Models 
{
    public class Store
    {
        //Two methods: get and set
        public List<Order> Orders {get; set; }

        void CreateOrder() 
        {
            Orders.Add(new Order());

        }

        void DeleteOrder() 
        {

        }
    }
}