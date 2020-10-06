using System.Threading.Tasks;
using Blog.Data.FileManager;
using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IPostRepository _repo;
        private IFileManager _fileManager;
        public PanelController(IPostRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
           

        }
        public IActionResult Index()
        {
            var posts = _repo.GetAllPosts();
            return View(posts);
        }    

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = _repo.GetPost((int)id);
                return View(new PostViewModel
                {
                    Id=post.Id,
                    Title=post.Title,
                    Description=post.Description,
                    Body=post.Body,
                    CurrentImage=post.Image,
                    CategoryId=post.CategoryId,
                    Tags=post.Tags

                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Id = vm.Id,
                    Title = vm.Title,
                    Description=vm.Description,
                    Body = vm.Body,     
                    CategoryId=vm.CategoryId,
                    Tags=vm.Tags
                };
                if (vm.Image == null)
                    post.Image = vm.CurrentImage;
                else
                    post.Image = await _fileManager.SaveImage(vm.Image);


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
            return View(viewName:"Edit");
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.DeletePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
