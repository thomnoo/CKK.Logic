using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKKTests.Test
{
    public class StoreItemTests
    {
        [Fact]
        public void StoreItem_GetQuantity_Success()
        {
            try
            {
                //Assemble
                StoreItem item = new StoreItem(new Product(),5);
                int expected = 5;

                //Act
                int actual = item.GetQuantity();

                //assert
                Assert.Equal(expected, actual);
            }

            catch (Exception e) { throw new Exception(e.Message); }
        }

        [Fact]
        public void StoreItem_GetProduct_Success()
        {
            try
            {
                //Assemble
                StoreItem item = new StoreItem(new Product(), 5);
                Product expected = new Product();
                item.SetProduct(expected);

                //Act
                Product actual = item.GetProduct();

                //Assert
                Assert.Equal(expected, actual);

            }

            catch (Exception e) { throw new Exception(e.Message); }
        }



    }
}
