namespace PriceQuotationApp.Models
{
    public class PriceQuotationModel
    {
        public decimal Subtotal { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}