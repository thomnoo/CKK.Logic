
using CKK.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
       

        private List<InventoryItem> _products;
       

        public ShoppingCart(Customer cust)
        {
            _products = new List<InventoryItem>();
            Customer = cust;
      
        }

        public Customer Customer { get; set; }

        public int GetCustomerId()
        {
            return Customer.Id;
        }

        public InventoryItem GetProductById(int id)
        {
            InventoryItem item = null;

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

        public InventoryItem AddProduct(Product prod, int quantity)
        {
            InventoryItem item = null;

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
                _products.Add( new ShoppingCartItem(prod, quantity));
                item = _products[_products.Count - 1];
            }
            return item;
        }

        public InventoryItem RemoveProduct(int id, int quantity)
        {
            InventoryItem item = null;

            var list =
                from p in _products
                where p.Product.Id == id
                select p;

            if (list.Any())
            {
                if (list.First().Quantity <= quantity)
                {
                    list.First().Quantity = 0;
                    item = list.First();
                    _products.Remove(list.First());
                }
                else
                {
                    list.First().Quantity -= quantity;
                    item = list.First();
                }
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
    }
}
