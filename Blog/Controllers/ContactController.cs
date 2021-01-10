using Blog.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            //var mailSender = new MailSendHelper();
            //mailSender.SendMessage();
            return View();
        }
    }
}
