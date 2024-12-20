namespace ShopApplication.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
