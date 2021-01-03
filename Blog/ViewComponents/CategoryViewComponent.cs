using Blog.Data.Repositories.Abstract;
using Blog.Data.Repositories.Concrete;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private ICategoryRepository _categoryrepo;
        private IPostRepository _postrepo;
        public CategoryViewComponent(ICategoryRepository categoryrepo, IPostRepository postRepository)
        {
            _categoryrepo = categoryrepo;
            _postrepo = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryrepo.Categories();
            var posts = _postrepo.GetAllPosts();

            return await Task.FromResult(View(new CategoryListViewModel { 
            Categories=categories,
            Posts=posts,
            }));
        }
    }
}
