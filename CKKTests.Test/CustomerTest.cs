namespace CKKTests.Test
{
    public class CustomerTest
    {
        [Fact]
        public void Customer_GetId_Success()
        {
            try
            {
                //Assemble
                Customer cust = new Customer();
                cust.SetId(420);
                //Act
                int expected = 420;
                int actual = cust.GetId();
                //Assert
                Assert.Equal(expected, actual);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        [Fact]
        public void Customer_SetId_Success()
        {
            try
            {
                Customer cust = new Customer();
                cust.SetId(420);

                int expected = 420;
                int actual = cust.GetId();

                Assert.Equal(expected, actual);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        [Fact]
        public void Customer_GetName_Success()
        {
            try
            {
                //Assemble
                Customer cust = new Customer();
                cust.SetName("Tom");
                //Act
                string expected = "Tom";
                string actual = cust.GetName();

                //Assert
                Assert.Equal(expected, actual);
            }
            catch (Exception e) { throw new Exception(e.Message) ; }
        }

    }
}
