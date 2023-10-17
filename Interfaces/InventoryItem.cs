using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;

[Serializable]
public abstract class InventoryItem
{
    private int _quantity;

    
    public Product Product { get; set; }
    public int Quantity
    {
        get { return _quantity; }

        set
        {
            if (value < 0)
            {
                throw new InventoryItemStockTooLowException();
            }
            else
            {
                _quantity = value;
            }
        }
    }
}
