using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public float UnitPrice { get; set; }
        public int StockQuantity { get; set; }
        public string ProductName { get; set; }
        public int StockId { get; set; }
    }
}