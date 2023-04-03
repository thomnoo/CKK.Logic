using CKK.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;



namespace CKK.Logic.Models
{
    public class Store : Entity
    {
       
        private List<StoreItem> _products = new List<StoreItem>();

       


        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            StoreItem storeItem = null;

            if(quantity <= 0) { return storeItem; }

            var list =
                  from p in _products
                  where p.Product == prod
                  select p;

            if (list.Any())
            {
                list.First().Quantity += quantity;
                storeItem = list.First();
            }
            else
            {
                StoreItem newItem = new StoreItem(prod,quantity);
                _products.Add(newItem);
                storeItem = newItem;
            }

            return storeItem;
        }




        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            StoreItem item = null;
            var list =
                 from p in _products
                 where p.Product.Id == id
                 select p;

            if (list.Any())
            {
                if (list.First().Quantity < quantity)
                {
                    quantity = list.First().Quantity;
                }

                list.First().Quantity -= quantity;
                item = list.First();
            }
            


            return item;
        }




        public List<StoreItem> GetStoreItems()
        {
            return _products;
        }




        public StoreItem FindStoreItemById(int id)
        {
            StoreItem storeItem = null;

            var list =
                from item in _products
                where item.Product.Id.Equals(id)
                select item;

            if (list.Any())
            {
                storeItem = list.First();
            }
            return storeItem;
        }




    }

}




