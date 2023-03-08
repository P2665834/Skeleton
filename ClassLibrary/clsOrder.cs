using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int Price { get; set; }
        public int OrderID { get; set; }
        public DateTime DateRecieved { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int OrderLineID { get; set; }
        public int Quantity { get; set; }
        public bool Dispatched { get; set; }
    }
}