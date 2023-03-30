using CKK.Logic.Interfaces;



namespace CKK.Logic.Models
{
    public class Product : Entity
    {
       
        public decimal Price { get; set; }
       

        public Product (int id,string name,decimal price) : base(id,name)
        {
            Price = price;
        }

        public Product() : base(0, "") { }
    }
}
