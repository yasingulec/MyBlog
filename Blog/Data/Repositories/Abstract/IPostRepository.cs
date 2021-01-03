using Blog.Models;
using Blog.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstract
{
    public interface IPostRepository
    {
        Task<Post> GetPost(int id);
        List<Post> GetAllPosts();
        List<Post> GetAllPostsByCategory(string categoryname);
        List<Post> GetTrendingPosts();
        List<Post> GetFeaturePosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        Task DeletePost(int id);
        Task<bool> SaveChangesAsync();
        void AddSubComment(SubComment comment);
    }
}
