using Blog.Data.Repositories.Abstract;
using Blog.Helpers;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
        public IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactViewModel vm)
        {
            var contact = new Contact
            {
                Name=vm.Name,
                Email=vm.Email,
                Message=vm.Message,
                Website=vm.Website
            };
           await _contactRepository.AddContact(contact);
           await _contactRepository.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }

    }
}
