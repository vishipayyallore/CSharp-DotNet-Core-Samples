namespace Invoice.External
{
    // Note: this is an external SDK we have no control over
    // nothing can be changed here

    public static class ExternalInvoiceService
    {
        public static ExternalInvoice[] GetInvoices(string supplierId)
        {
            return new ExternalInvoice[0];
        }
    }
}
