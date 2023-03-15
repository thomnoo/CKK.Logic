using System.Collections.Generic;
using System.Linq;


namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;

        private List<StoreItem> _products = new List<StoreItem>();

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void AddStoreItem(Product prod, int quantity)
        {
            var list =
                  from p in _products
                  where p.GetProduct().GetId() == prod.GetId()
                  select p;

            if (list.Any())
            {
                list.First().SetQuantity(list.First().GetQuantity() + quantity);
            }
            else
            {
                _products.Add(new StoreItem(prod, quantity));
            }

        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            StoreItem item = null;
            var list =
                 from p in _products
                 where p.GetProduct().GetId() == id
                 select p;
            if (list.Any())
            {
                if (list.First().GetQuantity() < quantity)
                {
                    quantity = list.First().GetQuantity();
                }

                list.First().SetQuantity(list.First().GetQuantity() - quantity);
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
                where item.GetProduct().GetId().Equals(id)
                select item;
            if (list.Any())
            {
                storeItem = list.First();
            }
            return storeItem;
        }

    }

}




