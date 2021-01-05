using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class CrustTypes
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public CrustTypes()
        {
            Name = "";
            Price = 0;
        }
        public CrustTypes(string name)
        {
            Name = name;
            if(Name.Equals("Thin"))
            {
                Price = 5;
            }
            else if(Name.Equals("Regular"))
            {
                Price = 6;
            }
            else if(Name.Equals("Pan"))
            {
                Price = 8;
            }
        }
    }
}