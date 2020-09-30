using Blog.Data.Repositories.Abstract;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _ctx;
        public CategoryRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public List<Category> Categories()
        {
            return _ctx.Categories.ToList();
        }
    }
}
