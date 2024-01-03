﻿

using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class ShoppingCartItem : InventoryItem
    {
        public Product Product { get; set; }
        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        private int quantity {  get; set; }
        public int Quantity
        {
            get => quantity;
            set
            {
                if(value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }

        public decimal GetTotal()
        {
            return Product.Price * Quantity;
        }

    }

}






