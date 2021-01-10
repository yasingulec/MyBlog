using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class IndexPageViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public int PageNumber { get; set; }
        public bool NextPage { get; set; }
        public string categoryName { get; set; }
        public int PageCount { get; set; }
    }
}
