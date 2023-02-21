namespace ClassLibrary
{
    public class clsOrderLine
    {
        public clsOrderLine()
        {
        }

        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public bool Dispatched { get; set; }
    }
}