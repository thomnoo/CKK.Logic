using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

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

        public string AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
                return $" Added {_product1} to product 1";
            }

            else if (_product2 == null)
            {
                _product2 = prod;
                return $" Added {_product2} to product 2";
            }

            else if (_product3== null)
            {
                _product3 = prod;
                return $" Added {_product3} to product 3";
            }

            else
            {
                return $" No available product slots";
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

        public Product FindStoreById(int id)
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
