using CKK.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CKK.Logic.Exceptions;
using System;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {

        private int idcounter = 1;

        public List<StoreItem> _products = new List<StoreItem>();


        public string UpdateStoreItem(StoreItem item)
        {
            for(var i = 0; i < _products.Count; i++)
            {
                StoreItem founditem = _products[i];
                if(founditem.Product.Id == item.Product.Id)
                {
                    _products[i] = item;

                    return "Add Product Successful";
                }
            }

            return "Adding Product Failed";
        }

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            prod.Id = idcounter;
            StoreItem item = new StoreItem(prod,quantity);
            _products.Add(item);
            idcounter++;
            return item;

            //StoreItem storeItem = null;

            //if (quantity < 0)
            //{
            //    throw new InventoryItemStockTooLowException();
            //}

            //if (quantity == 0) { return storeItem; }

            //var list =
            //      from p in _products
            //      where p.Product == prod
            //      select p;

            //if (list.Any())
            //{
            //    list.First().Quantity += quantity;
            //    storeItem = list.First();
            //}
            //else
            //{
            //    StoreItem newItem = new StoreItem(prod, quantity);
            //    _products.Add(newItem);
            //    storeItem = newItem;
            //}
            //return storeItem;
                
                    


        }




        public StoreItem RemoveStoreItem(int id, int quantity)
        {

            StoreItem item = null;

            if (quantity < 0)
            { 
                throw new ArgumentOutOfRangeException();
            }

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
            else
            {
                throw new ProductDoesNotExistException();
            }

            return item;
        }

        public void DeleteStoreItem(int id)
        {
            foreach (var item in _products)
            {
                if(item.Product.Id == id)
                {
                    _products.Remove(item);
                    break;
                }
            }
        }




        public List<StoreItem> GetStoreItems()
        {
            return _products;
        }




        public StoreItem FindStoreItemById(int id)
        {
            StoreItem storeItem = null;

            if (id < 0)
            {
                throw new InvalidIdException();
            }

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




