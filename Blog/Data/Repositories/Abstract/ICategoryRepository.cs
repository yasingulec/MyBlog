using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstract
{
   public interface ICategoryRepository
    {
        List<Category> Categories();
    }
}
