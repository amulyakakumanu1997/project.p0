using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class CheesePizza : APizzaModel
    {
        public CheesePizza(Sizes size,CrustTypes crust)
        {
            AddName("Cheese Pizza");
            AddCrust(crust);
            AddSize(size);
            AddToppings();
            ComputePrice();
        }
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Crusts = new CrustTypes();
            Sizes = new Sizes();
            Toppings = new List<Topping>();
        }

        public void AddCrust(CrustTypes crust)
        {
            Crusts = crust;
        }

        public void AddSize(Sizes size)
        {
            Sizes = size;
        }

        protected void AddToppings()
        {
            Toppings = new List<Topping>(){
            new Topping("cheese"),
            new Topping("sauce")
          };
        }
        protected void AddName(string name)
        {
            Name = name;
        }
    }
}