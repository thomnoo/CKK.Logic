

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

        public void AddStoreItem(Product prod)
        {
            bool productExists = false;

            for (int i = 0; i < _products.Count; i++)
            {
                
                if (_products[i].GetId() == prod.GetId())
                {
                    _products[i].SetQuantity(_products[i].GetQuantity() + prod.GetQuantity());
                    productExists = true;
                    break;
                }           
            }

            if (!productExists)
            {
                _products.Add(prod);
            }
        }

        public void RemoveStoreItem(int productNumber)
        {
            switch (productNumber)
            {
                case 1:
                    if(_product1 != null)
                    {
                        _product1 = null;
                    }
                    break;

                case 2:
                    if(_product2 != null)
                    {
                      _product2= null;
                    }
                    break;

                case 3:
                    if (_product3 != null)
                    {
                        _product3 = null;
                    }

                    break;

                default:
                    
                    break;
            }
        }


        public Product GetStoreItem(int productNumber)
        {
            switch (productNumber)
            {
                case 1:
                    return _product1;
                case 2:
                    return _product2;
                case 3:
                    return _product3;
                    default:
                    return null;
            }
            
        
        
        }

        public Product FindStoreItemById(int id)
        {
            if (_product1 != null && _product1.GetId() == id)
            {
                return _product1;
            }

            else if (_product2 != null && _product2.GetId() == id)
            {
                return _product2;
            }

            else if (_product3 != null && _product3.GetId() == id)
            {
                return _product3;
            }

            else
            
            {
                return  null;
            }

        }


    }
}
