namespace ClassesAndGenerics
{
    public class CreditNote : AcmeObject
    {
        public override int Id { get; set; }
        public decimal TotalValue { get; set; }
        public int LineNumber { get; set; }
        public string StockItem { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quanty { get; set; }
    }

}
