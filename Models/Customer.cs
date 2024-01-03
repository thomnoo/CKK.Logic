

using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Customer : Entity
    {

        public string Address { get; set; }
        public int CustomerId {  get; set; }
        public string CustomerAddress { get; set; }
        public int ShoppingCartId {  get; set; }
        public ShoppingCart Cart { get; set; }


    }   
}
