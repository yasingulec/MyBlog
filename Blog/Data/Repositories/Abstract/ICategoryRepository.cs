using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task<List<Category>> Categories();
        Task<Category> GetCategory(int id);
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task RemoveCategory(int id);
        Task<bool> SaveChangesAsync();
    }
}
