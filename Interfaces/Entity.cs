using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int _id;

        public string Name { get; set; }
        public int Id 
        {
            get { return _id; }
            
            set
            {
                if (value <= 0)
                {
                    throw new InvalidIdException();
                }
                else
                {
                    _id = value;
                }
            }
        }

        
    }
}
