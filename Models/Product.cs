using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int IsFeatured { get; set; } = 0;


        #region DISPLAY PROPERTIES
        public string Display_Id
        {
            get => $"Id: {Id}";
        }
        public string Display_Name
        {
            get => $"Name: {Name}";
        }

        public string Display_Price
        {
            get => $"Price: {Price}";
        }

        public string Display_Quantity
        {
            get => $"Quantity: {Quantity}";
        }

        #endregion
    }
}
