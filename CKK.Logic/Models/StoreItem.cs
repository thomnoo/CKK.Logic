using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class StoreItem
    {
        private Product _product;
        private int _quanity;

        public StoreItem(Product product,int quanity)
        {
            _product = product;
            _quanity = quanity;
        }

        public int GetQuanity()
        {
            return _quanity;
        }

        public void SetQuanity(int quanity)
        {
          _quanity = quanity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public Product SetProduct(Product product)
        {
            return product;
        }





    }
}
