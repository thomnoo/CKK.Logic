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
                //assemble
                ShoppingCart cart = new ShoppingCart(new Customer());
                Product expected = new Product();
                ShoppingCartItem item = new ShoppingCartItem(expected, 1);

                //act
                Product actual = cart.AddProduct(expected).GetProduct();   

                //assert
                Assert.Equal(expected, actual);

            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        [Fact]
        public void ShoppingCart_RemovedProduct_ChangingQuantity()
        {
            try
            {
                //Assemble
                ShoppingCart cart = new ShoppingCart(new Customer());
                Product product = new Product();
                int expected = 1;

                //Act
                cart.AddProduct(product , 3);
                int actual = cart.RemoveProduct(product, 2).GetQuantity();
                
                //Assert
                Assert.Equal(expected, actual);


            }
            catch (Exception c) { throw new Exception(c.Message); }

        }

        [Fact]
        public void ShoppingCart_RemoveProduct_NullifyProduct()
        {
            try
            {
                //Assemble
                ShoppingCart cart = new ShoppingCart(new Customer());
                Product product = new Product();
                ShoppingCartItem expected = null;

                //Act
                cart.AddProduct(product, 3);
                ShoppingCartItem actual = cart.RemoveProduct(product, 3);
                //Assert
                Assert.Equal(expected, actual);
            }

            catch (Exception c) { throw new Exception(c.Message); }
        }

    }
}