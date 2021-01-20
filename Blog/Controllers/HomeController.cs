using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Blog.Models.Comments;
using Blog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _repo;
        private IFileManager _fileManager;
        public HomeController(IPostRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;

        }
        public IActionResult Index( int pageNumber, string categoryName)
        {
            if (pageNumber < 1)
                return RedirectToAction("Index", new { categoryName, pageNumber = 1 });

            //var vm = new IndexPageViewModel
            //{
            //    Posts = string.IsNullOrEmpty(categoryname) ? _repo.GetAllPosts(pageNumber) : _repo.GetAllPostsByCategory(categoryname),
            //    PageNumber=pageNumber,
            //};

            var vm = _repo.GetAllPosts(pageNumber, categoryName);
          
            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> Post(int id)
        {
            var post = await _repo.GetPost(id);
            var posts = _repo.GetAllPosts().Take(2);
            var postandList = new PostAndListViewModel
            {
                Post = post,
                Posts = posts,
            };
            postandList.Post.ViewCount += 1;
            _repo.UpdatePost(postandList.Post);
            await _repo.SaveChangesAsync();

            return View(postandList);
        }
        [HttpPost]
        public IActionResult Post(Post post)
        {
            return View("Post");
        }
        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Post", new { id = vm.PostId });
            var post = await _repo.GetPost(vm.PostId);
            if (vm.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();
                post.MainComments.Add(new MainComment
                {
                    Name = vm.Name,
                    Message = vm.Message,
                    Created = DateTime.Now,
                });
                _repo.UpdatePost(post);
            }
            else
            {
                var subComment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Name = vm.Name,
                    Message = vm.Message,
                    Created = DateTime.Now
                };
                _repo.AddSubComment(subComment);
            }
            await _repo.SaveChangesAsync();
            return RedirectToAction("Post", new { id = vm.PostId });
        }
        [HttpGet("/Image/{image}")]
        [ResponseCache(CacheProfileName = "Monthly")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf(".") + 1);
            return new FileStreamResult(_fileManager.imageStream(image), $"image/{mime}");
        }
    }
}
