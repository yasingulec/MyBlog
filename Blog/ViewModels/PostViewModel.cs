using Blog.Validations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(5*1024*1024)]
        [AllowedExtensions(new string[] {".jpg",".png",".jpeg",".gif"})]
        public IFormFile Image { get; set; } = null;
    }
}
