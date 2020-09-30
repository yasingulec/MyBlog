using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstract
{
   public interface IPostRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        List<Post> GetAllPostsByCategory(string categoryname);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
        Task<bool> SaveChangesAsync();
    }
}
