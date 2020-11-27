using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repositories.Abstract;
using Blog.Models;
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
        public IActionResult Index(string categoryname)
        {
            var posts = string.IsNullOrEmpty(categoryname) ? _repo.GetAllPosts().OrderByDescending(x => x.Created) : _repo.GetAllPostsByCategory(categoryname).OrderByDescending(x => x.Created);
            return View(posts);
        }
        [HttpGet]
        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            post.ViewCount += 1;
            _repo.UpdatePost(post);
            _repo.SaveChangesAsync();
            return View(post);
        }
        [HttpPost]
        public IActionResult Post(Post post)
        {
            return View("Post");
        }
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf(".") + 1);
            return new FileStreamResult(_fileManager.imageStream(image), $"image/{mime}");
        }
    }
}
