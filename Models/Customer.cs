

using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
       
      public string Address { get; set; }
      

        public Customer(int id,string name, string address) : base(id,name)
        {
           Address = address;
        }

        public Customer() : base(0, "") { }
    }
}
