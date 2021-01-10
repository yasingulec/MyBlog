using Blog.Models;
using Blog.Models.Comments;
using Blog.ViewModels;
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
        IndexPageViewModel GetAllPosts(int pageNumber,string categoryname);

        List<Post> GetTrendingPosts();
        List<Post> GetFeaturePosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        Task DeletePost(int id);
        Task<bool> SaveChangesAsync();
        void AddSubComment(SubComment comment);
    }
}
