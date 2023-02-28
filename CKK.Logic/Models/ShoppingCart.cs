

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

       public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetProduct().GetId() == id)
            { return _product1; }

            else if (_product2.GetProduct().GetId() == id)
            { return _product2; }

            else if (_product3.GetProduct().GetId() == id)
            { return _product3; }

            else
            { return null; }
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod,1);
        }

        public ShoppingCartItem AddProduct(Product prod,int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }

            ShoppingCartItem item = null;

            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                item = _product1;
            }

            else if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                item = _product2;
            }

            else if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                item = _product3;
            }

            if (item != null) 
            {
                item.SetQuantity(item.GetQuantity() + quantity);
            }

            else if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(prod, quantity);
                item = _product1;
            }

            else if (_product2 == null)
            {
                _product2 = new ShoppingCartItem(prod, quantity);
                item = _product2;
            }

            else if (_product3 == null)
            {
                _product3 = new ShoppingCartItem(prod, quantity);
                item = _product3;
            }

            return item;
        }

        public ShoppingCartItem RemoveProduct(Product prod,int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }

            ShoppingCartItem item = GetProductById(prod.GetId());

            if (item != null)
            {
                int newQuantity = item.GetQuantity() - quantity;

                if(newQuantity < 0)
                {
                    return null;
                }

                else if (newQuantity == 0)
                {
                    return null;
                }

                else
                {
                    item.SetQuantity(newQuantity);
                    return item;
                }

            }

            return null;

        }

        public decimal GetTotal()
        {
            decimal total = 0;

            if (_product1 != null)
            {
                total += _product1.GetTotal();
            }

            if (_product2 != null)
            {
                total += _product2.GetTotal();
            }

            if (_product3 != null)
            {
                total += _product3.GetTotal();
            }

            return total;
        }

        public ShoppingCartItem GetProduct(int prodNum)
        {
            if (_product1 != null && _product1.GetProduct().GetId() == prodNum)
            {
                return _product1;
            }

            if (_product2 != null && _product2.GetProduct().GetId() == prodNum)
            {
                return _product2;
            }

            if (_product3 != null && _product3.GetProduct().GetId() == prodNum)
            {
                return _product3;
            }

            return null;
        }

    }

}
