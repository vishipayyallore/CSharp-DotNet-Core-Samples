namespace ClassesAndGenerics
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal TotalValue { get; set; }
        public int LineNumber { get; set; }
        public string StockItem { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
    }

}