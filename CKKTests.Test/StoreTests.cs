using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKKTests.Test
{
    public class StoreTests
    {
        [Fact]
        public void Store_FindItemById_Success()
        {
            try
            {
                //Assemble
                Store store = new Store();
                Product expected = new Product();
                expected.SetId(666);
                //Act
                store.AddStoreItem(expected);
                Product actual = store.FindStoreItemById(666);
                //Assert
                Assert.Equal(expected, actual);

            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        [Fact]
        public void Store_RemoveStoreItem_Success()
        {
            try
            {
                //Assemble
                Store store = new Store();
                Product expected = null;
                store.AddStoreItem(new Product());
                //Act
                store.RemoveStoreItem(1);
                Product actual = store.GetStoreItem(1);
                //Assert
                Assert.Equal(expected, actual);
            }
            catch (Exception e) { throw new Exception(e.Message); }
         }





    }
   

}

