using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal price { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
