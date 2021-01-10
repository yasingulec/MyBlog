using System.Threading.Tasks;
using Blog.Data.FileManager;
using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IPostRepository _repo;
        private IFileManager _fileManager;
        private ICategoryRepository _categoryRepository;
        public PanelController(IPostRepository repo, IFileManager fileManager, ICategoryRepository categoryRepository)
        {
            _repo = repo;
            _fileManager = fileManager;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var posts = _repo.GetAllPosts();
            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var categories = await _categoryRepository.Categories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            if (id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = await _repo.GetPost((int)id);
                return View(new PostViewModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Description = post.Description,
                    Author = post.Author,
                    Body = post.Body,
                    CurrentImage = post.Image,
                    isFeatured = post.isFeatured,
                    CategoryId = post.CategoryId,
                    Tags = post.Tags,
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel vm)
        {
            var categories = await _categoryRepository.Categories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            if (ModelState.IsValid)
            {
                if (vm.CategoryId==0)
                {
                    return StatusCode(404);
                }
                var post = new Post
                {
                    Id = vm.Id,
                    Title = vm.Title,
                    Description = vm.Description,
                    Author = "Yasin Güleç",
                    Body = vm.Body,
                    CategoryId = vm.CategoryId,
                    isFeatured = vm.isFeatured,
                    Tags = vm.Tags
                };
                if (vm.Image == null)
                    post.Image = vm.CurrentImage;
                else
                {
                    if (!string.IsNullOrEmpty(vm.CurrentImage))                   
                        _fileManager.RemoveImage(vm.CurrentImage);
                    
                    post.Image =  _fileManager.SaveImage(vm.Image);
                }
              


                if (vm.Id > 0)
                {
                    post.CategoryId = vm.CategoryId;
                    _repo.UpdatePost(post);
                }
                else
                {
                    _repo.AddPost(post);
                }

                if (await _repo.SaveChangesAsync())
                {
                    return RedirectToAction("Index");
                }
                return View(post);
            }
            return View(viewName: "Edit");
        }

        [HttpGet]
        public async Task <IActionResult> Remove(int id)
        {
           await _repo.DeletePost(id);
           await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            await Task.WhenAll(_categoryRepository.AddCategory(category), _categoryRepository.SaveChangesAsync());
            return RedirectToAction("Categories");
        }
        [HttpGet]
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryRepository.Categories();
            return View(categories);
        }
        [HttpGet]
        public async Task <IActionResult> RemoveCategory(int id)
        {
           await _categoryRepository.RemoveCategory(id);
           await  _categoryRepository.SaveChangesAsync();
            return RedirectToAction("Categories");
           
        }
    }
}
