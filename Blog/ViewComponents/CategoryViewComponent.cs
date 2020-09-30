using Blog.Data.Repositories.Abstract;
using Blog.Data.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private ICategoryRepository _categoryrepo;
        public CategoryViewComponent(ICategoryRepository categoryrepo)
        {
            _categoryrepo = categoryrepo;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var categories =  _categoryrepo.Categories();
            return await Task.FromResult(View(categories));
        }
    }
}
