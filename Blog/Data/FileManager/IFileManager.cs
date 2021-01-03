using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.FileManager
{
   public interface IFileManager
    {
        FileStream imageStream(string image);
        string SaveImage(IFormFile image);
        bool RemoveImage(string image);
    }
}
