using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddCategory(Category category)
        {
            await _ctx.AddAsync(category);
        }

        //todo:category ekleme metodu, image property
        public async Task<List<Category>> Categories()
        {
            var categories = await _ctx.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _ctx.Categories.FirstOrDefaultAsync(x => x.Id == id);
            return category;
        }
        public async Task RemoveCategory(int id)
        {
            var Category= await GetCategory(id);
            _ctx.Categories.Remove(Category);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public Task UpdateCategory(Category category)
        {
            var updatedEntry= Task.Run( ()=> _ctx.Categories.Update(category));
            return updatedEntry;
        }
    }
}
