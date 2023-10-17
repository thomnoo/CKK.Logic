

using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {


        public StoreItem(Product product, int quantity)
        {
            base.Product = product;
            base.Quantity = quantity;
        }

       
    }
}
