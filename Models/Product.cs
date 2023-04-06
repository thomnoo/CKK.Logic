using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        private decimal _price;

        public decimal Price
        {
            get { return _price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _price = value;
                }
            }
        }
    }
}
