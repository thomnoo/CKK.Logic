

using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class ShoppingCartItem : InventoryItem
    {
        public ShoppingCartItem(Product product, int quantity)
        {
            base.Product = product;
            base.Quantity = quantity;
        }
        
        public decimal GetTotal()
        {
            return Product.Price * Quantity;
            
        }

    }

}




       

