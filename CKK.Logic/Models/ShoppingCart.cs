

using System.Collections.Generic;
using System.Linq;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;

        private List<ShoppingCartItem> _products;

       public ShoppingCart(Customer cust)
        {
            _customer = cust;
            _products = new List<ShoppingCartItem>();
        }




        public int GetCustomerId()
        {
            return _customer.GetId();
        }




        public ShoppingCartItem GetProductById(int id)
        {
            ShoppingCartItem item = null;

            var list =
                from i in _products
                where i.GetProduct().GetId().Equals(id) // where i.GetProduct().GetId() == id
                select i;

            if(list.Any())
            {
                item = list.First();
            }

            
             
            

            return item;
        }




        public ShoppingCartItem AddProduct(Product prod,int quantity)
        {
            ShoppingCartItem item = null;

            var list =
                from p in _products
                where p.GetProduct() == prod
                select p;
            if(list.Any())
            {
                list.First().SetQuantity(list.First().GetQuantity() + quantity);
            }

            else 
            {
                _products.Add(new ShoppingCartItem(prod,quantity));
                item = _products[_products.Count - 1];
                
            }
            return item;    
        }




        public ShoppingCartItem RemoveProduct(Product prod,int quantity)
        {
            ShoppingCartItem item = null;

            var list =
                from p in _products
                where p.GetProduct() == prod
                select p;
            if(list.Any())
            {
                if(list.First().GetQuantity() <= quantity)
                {
                    list.First().SetQuantity(0);
                    item = list.First();
                    _products.Remove(list.First());
                }

                else
                {
                    int newQuantity = list.First().GetQuantity() - quantity;
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
                total += item.GetTotal();
            }

            return total;
           
        }

      


        public List<ShoppingCartItem> GetProducts()
        {
            return _products;
        }

    }

}
