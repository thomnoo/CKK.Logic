﻿

namespace CKK.Logic
{
    public class Customer
    {
       private int _id;
       private string _name;
       private string _address;

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

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string address)
        {
         _address = address;
        }












    }
}
