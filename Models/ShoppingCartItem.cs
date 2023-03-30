﻿

using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {
        public ShoppingCartItem(Product product, int quantity) : base(product,quantity)
        {
            
        }


        
        public decimal GetTotal()
        {
            return Product.Price * Quantity;
            
        }


    }

}

       

