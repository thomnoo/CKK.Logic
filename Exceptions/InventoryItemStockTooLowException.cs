using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException : Exception
    {
        public InventoryItemStockTooLowException() : base() { }
        public InventoryItemStockTooLowException(string message) : base(message) { }
    }
}
