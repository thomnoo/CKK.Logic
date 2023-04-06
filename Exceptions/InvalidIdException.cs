using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() : base() { }
        public InvalidIdException(string message) : base(message) { }
    }
}
