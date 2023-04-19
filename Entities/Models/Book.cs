namespace Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }

        // Ref: navigation property
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
