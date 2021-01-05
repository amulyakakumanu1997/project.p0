using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class ChickenPizza : APizzaModel
    {
        public ChickenPizza(Sizes size,CrustTypes crust)
        {
            AddName("Chicken Pizza");
            AddCrust(crust);
            AddSize(size);
            AddToppings();
            ComputePrice();
        }
        public ChickenPizza()
        {
            Name = "Chicken Pizza";
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
            new Topping("sauce"),
            new Topping("chicken"),
            new Topping("jalapeno")
          };
        }
        protected void AddName(string name)
        {
            Name = name;
        }
    }
}