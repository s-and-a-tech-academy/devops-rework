namespace REWORK.Models
{
    public class Product
    {
        // A simple model representing a product in our database.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}

