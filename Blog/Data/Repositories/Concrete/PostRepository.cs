using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Blog.Models.Comments;
using Blog.ViewModels;
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

        public void AddSubComment(SubComment comment)
        {
            _ctx.SubComments.Add(comment);
        }

        public async Task DeletePost(int id)
        {
            var post = await GetPost(id);
            _ctx.Posts.Remove(post);
        }

        public List<Post> GetAllPosts()
        {
            return _ctx.Posts.Include(x => x.MainComments).Include(p => p.Category).OrderByDescending(c => c.Created).ToList();
        }
        public IndexPageViewModel GetAllPosts(int pageNumber, string categoryname)
        {
            int pageSize = 5;
            int skipAmount = pageSize * (pageNumber - 1);
            var query = _ctx.Posts.AsQueryable();
            int postsCount = 0;
            if (string.IsNullOrEmpty(categoryname))
            {
                postsCount = query.Count();
                return new IndexPageViewModel
                {
                  
                    PageNumber = pageNumber,
                    PageCount= (int)Math.Ceiling(postsCount * 1.0 / pageSize),
                    NextPage = postsCount > skipAmount + pageSize,
                    categoryName=categoryname,
                    Posts = query.Include(p => p.Category).OrderByDescending(c => c.Created).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList(),
                };
            }
            else
            {
                 postsCount = GetAllPostsByCategory(categoryname).Count;
                return new IndexPageViewModel
                {
                    PageNumber = pageNumber,
                    PageCount =(int) Math.Ceiling ((double)postsCount / pageSize),
                    NextPage = postsCount > skipAmount + pageSize,
                    categoryName = categoryname,
                    Posts = query.Include(p => p.Category).Where(p => p.Category.Name.ToLower().Equals(categoryname.ToLower())).OrderByDescending(c => c.Created).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList(),

                };
            }

        }
        public List<Post> GetAllPostsByCategory(string categoryname)
        {
            return _ctx.Posts.Include(p => p.Category).Where(p => p.Category.Name.ToLower().Equals(categoryname.ToLower())).OrderByDescending(c => c.Created).ToList();
        }

        public List<Post> GetFeaturePosts()
        {
            return _ctx.Posts.Where(x => x.isFeatured == true).OrderByDescending(x => x.Created).Take(3).ToList();
        }

        public async Task<Post> GetPost(int id)
        {
            var post = await _ctx.Posts.Include(x => x.MainComments).ThenInclude(mc => mc.SubComments).Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            return post;
        }

        public List<Post> GetTrendingPosts()
        {
            return _ctx.Posts.Include(p => p.Category).OrderByDescending(x => x.ViewCount).Take(5).ToList();
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
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
