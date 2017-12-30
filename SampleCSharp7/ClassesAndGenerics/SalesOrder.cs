namespace ClassesAndGenerics
{
    public class SalesOrder : AcmeObject
    {
        public override int Id { get; set; }
        public decimal TotalValue { get; set; }
        public int LineNumber { get; set; }
        public string StockItem { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quanty { get; set; }
    }

}