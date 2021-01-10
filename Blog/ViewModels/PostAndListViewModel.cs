using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostAndListViewModel
    {
        public Post Post { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
