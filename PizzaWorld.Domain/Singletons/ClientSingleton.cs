using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Singletons
{
    public class ClientSingleton
    {
        //private readonly string _path = @"//PizzaWorld.Client//pizzaworld.xml"; //waiting for DB
        private static ClientSingleton _instance;
        public static ClientSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientSingleton();
                }
                return _instance;

            }
        }
        public List<Store> Stores { get; set; }
        public List<APizzaModel> Pizzas { get; set; }
        private ClientSingleton() 
        {
            Stores = new List<Store>();
        }

        public Store SelectStore()
        {
            int.TryParse(Console.ReadLine(), out int input);
            return Stores.ElementAtOrDefault(input);
        }
        public void PrintAllPizzas()
        {
            var chicken = new ChickenPizza();
            var pep = new PepperoniPizza();
            var cheese = new CheesePizza();
            System.Console.WriteLine("Here are the pizzas this store offers:");
            System.Console.WriteLine(chicken.Name);
            System.Console.WriteLine(pep.Name);
            System.Console.WriteLine(cheese.Name);
        }
        public List<APizzaModel> SelectPizzas()
        {
            bool Leave = true;
            List<APizzaModel> Pizzas = new List<APizzaModel>();
            APizzaModel test = new ChickenPizza();
            GenericPizzaFactory _factory = new GenericPizzaFactory();

            do
            {
                PrintAllPizzas();
                System.Console.WriteLine("Select a pizza\n 1: Chicken Pizza \n 2: Pepperoni Pizza \n 3: Cheese Pizza \n 5: Finish");
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        {
                            var size = SelectSize();
                            var crust = SelectCrust();
                            var pizza = new ChickenPizza(size,crust);
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 2:
                        {
                            var size = SelectSize();
                            var crust = SelectCrust();
                            var pizza = new PepperoniPizza(size,crust);
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 3:
                        {
                            var size = SelectSize();
                            var crust = SelectCrust();
                            var pizza = new CheesePizza(size,crust);
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 4:
                        {
                            
                            break;
                        }
                    case 5:
                        {
                            Leave = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid choice");
                            break;
                        }



                }

            } while (Leave);
            return Pizzas;
        }
        public CrustTypes SelectCrust()
        {
            while (true)
            {
                System.Console.WriteLine("what kind of crust would you like? \n1: Small\n2: Regular\n3: Pan");
                int.TryParse(System.Console.ReadLine(), out int input);
                switch(input)
                {
                    case 1:
                    {
                        CrustTypes crust = new CrustTypes("Thin");
                        return crust;
                    }
                    case 2:
                    {
                        CrustTypes crust = new CrustTypes("Regular");
                        return crust;
                    }
                    case 3:
                    {
                        CrustTypes crust = new CrustTypes("Pan");
                        return crust;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid entry please try again");
                        break;
                    }
                }
            }
        }
        public Sizes SelectSize()
        {
            while (true)
            {
                System.Console.WriteLine("what size would you like? \n1: Small\n2: Medium\n3: Large");
                int.TryParse(System.Console.ReadLine(), out int input);
                switch(input)
                {
                    case 1:
                    {
                        Sizes size = new Sizes("Small");
                        return size;
                    }
                    case 2:
                    {
                        Sizes size = new Sizes("Medium");
                        return size;
                    }
                    case 3:
                    {
                        Sizes size = new Sizes("Large");
                        return size;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid entry please try again");
                        break;
                    }
                }
            }
        }
    }
}