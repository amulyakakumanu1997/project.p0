using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel
    {
        public CrustTypes CrustTypes { get; set; }
        public Sizes Sizes { get; set; }
        public ICollection<Topping> Toppings { get; set; }
        public double Price { get; set; }
        public long PizzaID { get; set; }
        public long OrderID { get; set; }
        public string Name { get; set; }
        protected APizzaModel()
        {

        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            
            foreach (var t in Toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {Name} for ${Price}:\nCrust: {CrustTypes.Name}\nSize: {Sizes.Name}\nToppings: {sb.ToString()}";
        }
        public virtual void ComputePrice()
        {
            Price = CrustTypes.Price + Sizes.Price;
        }



    }
}