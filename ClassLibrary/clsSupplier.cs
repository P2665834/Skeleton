using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Available { get; set; }
        public DateTime DatePurchased { get; set; }
        public int QuantityOfProducts { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public float UnitPrice { get; set; }
    }
}