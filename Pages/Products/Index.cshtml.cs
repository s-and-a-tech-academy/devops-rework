using Microsoft.AspNetCore.Mvc.RazorPages;
using REWORK.Models;

namespace REWORK.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            // In the fictional company, this would be a simple query to a database.
            // We are using a hardcoded list for demonstration.
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "A powerful and lightweight laptop.", Price = 1200.00m },
                new Product { Id = 2, Name = "Mouse", Description = "An ergonomic wireless mouse.", Price = 45.00m },
                new Product { Id = 3, Name = "Keyboard", Description = "A mechanical keyboard with RGB lighting.", Price = 110.00m }
            };
        }
    }
}

