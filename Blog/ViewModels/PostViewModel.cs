using Blog.Validations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a title.")]
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        [Required(ErrorMessage = "Please enter an article's body.")]
        public string Body { get; set; } = "";        
        public string CurrentImage { get; set; }
        public string Tags { get; set; }
        public int CategoryId { get; set; }
        [DataType(DataType.Upload)]
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg", ".gif" })]
        public IFormFile Image { get; set; } = null;
    }
}
