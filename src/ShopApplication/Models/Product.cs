﻿namespace ShopApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
