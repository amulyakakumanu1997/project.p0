using Xunit;
namespace PizzaWorld.Domain.Models
{
    public  class OrderTests 
    {
        
        private void Test_OrderExists() 
        {
            var sut = new Order();

            //act 
            var actual = sut;

            //assert 

            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
            
        }
    }
}