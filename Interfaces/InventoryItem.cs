using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;


namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public InventoryItem(Product product,int quantity) 
        {
            
        
        }

        public  Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
