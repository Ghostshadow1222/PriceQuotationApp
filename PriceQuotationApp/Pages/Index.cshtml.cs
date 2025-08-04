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
            // Initialize with default values if needed
        }

        public IActionResult OnPost(string action)
        {
            if (action == "clear")
            {
                // Clear the form - reset all values
                PriceQuotation = new PriceQuotationModel();
                return Page();
            }
            else if (action == "calculate")
            {
                // For now, just return the page without calculation logic
                // Calculation logic will be added later
                return Page();
            }

            return Page();
        }
    }
}