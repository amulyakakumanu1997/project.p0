using System;
using System.Collections.Generic;

namespace PizzaWorld.Client using PizzaWorld.Domain.Models
{
    class Program 
    {
        static void Main(string[] args)
        {
            PrintAllStores();
        }

        static IEnumerable<Store> GetAllStores() 
        {
            
            return new List<Store>();
        }

        static void PrintAllStores() 
        {
            foreach(var store in GetAllStores())
            {
                System.Console.WriteLine(store);
            }
        }
    }
}
    