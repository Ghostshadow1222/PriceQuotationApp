using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "The sales price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The sales price must be a valid number that's greater than 0.")]
        [Display(Name = "Subtotal")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "The discount percent is required.")]
        [Range(0, 100, ErrorMessage = "The discount percent must be a valid number from 0 to 100.")]
        [Display(Name = "Discount percent")]
        public decimal? DiscountPercent { get; set; }

        [Display(Name = "Discount amount")]
        public decimal DiscountAmount { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }
    }
}