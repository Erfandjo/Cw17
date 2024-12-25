namespace ShopApplication.Models
{
    public class ProductUpdateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
