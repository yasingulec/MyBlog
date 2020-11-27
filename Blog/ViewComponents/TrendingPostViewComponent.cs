using Blog.Data.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    public class TrendingPostViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;
        public TrendingPostViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var posts = _postRepository.GetTrendingPosts();
            return await Task.FromResult(View(posts));
        }
    }
}
