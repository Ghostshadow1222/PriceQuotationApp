using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PriceQuotationModel PriceQuotation { get; set; } = new PriceQuotationModel();

        public void OnGet()
        {
            // Initialize with default values - leave Subtotal and DiscountPercent as null (empty)
            PriceQuotation.Subtotal = null;        // Will display as empty
            PriceQuotation.DiscountPercent = null; // Will display as empty
            PriceQuotation.DiscountAmount = 0.00m; // Will show $0.00
            PriceQuotation.Total = 0.00m;          // Will show $0.00
        }

        public IActionResult OnPost(string action)
        {
            if (action == "clear")
            {
                // Clear the form - reset all values including ModelState
                ModelState.Clear();
                PriceQuotation = new PriceQuotationModel
                {
                    Subtotal = null,        // Will display as empty
                    DiscountPercent = null, // Will display as empty
                    DiscountAmount = 0.00m, // Will show $0.00
                    Total = 0.00m          // Will show $0.00
                };
                return Page();
            }
            else if (action == "calculate")
            {
                // Validate the model
                if (ModelState.IsValid)
                {
                    // Calculate discount amount and total
                    // Since these are nullable, we use .Value to get the actual decimal values
                    PriceQuotation.DiscountAmount = PriceQuotation.Subtotal.Value * (PriceQuotation.DiscountPercent.Value / 100);
                    PriceQuotation.Total = PriceQuotation.Subtotal.Value - PriceQuotation.DiscountAmount;
                }
                // If validation fails, the validation errors will be displayed automatically
                return Page();
            }

            return Page();
        }
    }
}