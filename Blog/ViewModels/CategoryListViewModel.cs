using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class CategoryListViewModel
    {
        public List <Category> Categories { get; set; }
        public List <Post> Posts { get; set; }
    }
}
