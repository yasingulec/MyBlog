using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concrete
{
    public class PostRepository : IPostRepository
    {
        private AppDbContext _ctx;
        public PostRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
        }

        public void DeletePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
        }

        public List<Post> GetAllPosts()
        {
           return _ctx.Posts.ToList();
        }

        public List<Post> GetAllPostsByCategory(string categoryname)
        {
            return _ctx.Posts.Where(p => p.Category.Name.ToLower().Equals(categoryname.ToLower())).ToList();
        }

        public Post GetPost(int id)
        {
            return _ctx.Posts.Include(p=>p.Category).FirstOrDefault(p=>p.Id==id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync()>0)
            {
                return true;
            }
            return false;
        }

        public void UpdatePost(Post post)
        {
            _ctx.Posts.Update(post);
        }
    }
}
