using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class PepperoniPizza : APizzaModel
    {
        public PepperoniPizza(Sizes size, CrustTypes crust)
        {
            AddName("Pepperoni Pizza");
            AddCrust(crust);
            AddSize(size);
            AddToppings();
            ComputePrice();
        }
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            CrustTypes = new CrustTypes();
            Sizes = new Sizes();
            Toppings = new List<Topping>();
        }
        public void AddCrust(CrustTypes crust)
        {
            CrustTypes = crust;
        }

        public void AddSize(Sizes size)
        {
            Sizes = size;
        }

        protected  void AddToppings()
        {
            Toppings = new List<Topping>(){
                new Topping("cheese"),
                new Topping("sauce"),
                new Topping("pepperoni")
            };
        }
        protected  void AddName(string name)
        {
            Name = name;
        }
    }
}