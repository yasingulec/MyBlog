using System;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = "";
        public string Author { get; set; } = "";
        public int ViewCount { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool isFeatured { get; set; }
        public string Tags { get; set; } = "";
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
