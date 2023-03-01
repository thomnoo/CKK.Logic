using CKK.Logic.Models;

namespace CKK.SoppingCartTest.tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShoppingCart_GetTotal_Success()
        {
            try
            {
                // Assemble
                ShoppingCart cart = new ShoppingCart(new Customer());
                Product prod = new Product();


                //Act
                prod.SetPrice(4.20m);
                cart.AddProduct(prod);
                decimal Expected = prod.GetPrice();

                // Assert
                Assert.Equal(Expected, cart.GetTotal());

            }

            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        [Fact]
        public void ShoppingCart_AddProduct_Success()
        {
            try
            {
                //ass
                ShoppingCart cart = new ShoppingCart(new Customer());
                ShoppingCartItem item = new ShoppingCartItem(new Product(), 1);

                //act


                //assert
                Assert.Equal(item, cart.AddProduct(new Product(),1));

            }
            catch (Exception e) { throw new Exception(e.Message); }


        }

    }
}