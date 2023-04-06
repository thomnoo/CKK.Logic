

using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class StoreItem : InventoryItem
    {


        public StoreItem(Product product, int quantity)
        {
            base.Product = product;
            base.Quantity = quantity;
        }


    }
}
