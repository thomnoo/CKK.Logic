using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IShoppingCart
    {
        public decimal GetTotal();
        public InventoryItem GetProductById(int id);
        public List<InventoryItem> GetProducts();
        public InventoryItem AddProduct(Product prod, int quantity);
        public InventoryItem RemoveProduct(int id, int quantity);
        public int GetCustomerId();
    }
}
