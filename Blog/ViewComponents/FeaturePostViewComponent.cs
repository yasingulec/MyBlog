using Blog.Data.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    public class FeaturePostViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;
        public FeaturePostViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var posts = _postRepository.GetFeaturePosts();
            return await Task.FromResult(View(posts));
        }
    }
}
