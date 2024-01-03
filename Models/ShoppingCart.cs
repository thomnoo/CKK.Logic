
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {

        #region FIELDS AND PROPERTIES
        //FEILDS
        private List<InventoryItem> _products;

        //PROPERTIES
        public Customer Customer { get; set; }
        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
        #endregion




        #region METHODS

        // CONSTRUCTOR
        public ShoppingCart(Customer cust)
        {
            
            Customer = cust;

        }

        //GET CUSTOMER ID
        public int GetCustomerId()
        {
            return Customer.Id;
        }

        //GET PRODUCT BY ID NUMBER
        public InventoryItem GetProductById(int id)
        {
            InventoryItem item = null;

            if (id < 0)
            {
                throw new InvalidIdException();
            }

            var list =
                from i in _products
                where i.Product.Id == id
                select i;

            if (list.Any())
            {
                item = list.First();
            }

            return item;
        }

        //  ADD PRODUCTS TO SHOPPING CART
        public InventoryItem AddProduct(Product prod, int quantity)
        {
            InventoryItem item = null;

            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            if (quantity <= 0) { return item; }

            var list =
                from p in _products
                where p.Product == prod
                select p;

            if (list.Any())
            {
                list.First().Quantity += quantity;
            }
            else
            {
                ShoppingCartItems.Add(new ShoppingCartItem(prod, quantity));
                item = _products[_products.Count - 1];
            }
            return item;
        }

        //REMOVE PRODUCT FROM SHOPPING CART
        public InventoryItem RemoveProduct(int id, int quantity)
        {
            InventoryItem item = null;

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var list =
                from p in ShoppingCartItems
                where p.Product.Id == id
                select p;

            if (list.Any())
            {
                if (list.First().Quantity <= quantity)
                {
                    list.First().Quantity = 0;
                    item = list.First();
                    ShoppingCartItems.Remove(list.First());
                }
                else
                {
                    list.First().Quantity -= quantity;
                    item = list.First();
                }
            }
            else
            {
                throw new ProductDoesNotExistException();
            }

            return item;
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var item in _products)
            {
                total += item.Product.Price * item.Quantity;
            }

            return total;
        }

        public List<InventoryItem> GetProducts()
        {
           
            return _products;
        }
        #endregion
    }
}
