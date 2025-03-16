namespace MVC_PROJECT.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Relationships
        public int CategoryId { get; set; }
        public Category? Category { get; set; }  // navigational Property
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>(); // a product can be many order items
        public ICollection<ProductIngredient> ProductIngredients { get; set; } = new HashSet<ProductIngredient>(); // A product can have many Ingredients
    }
}