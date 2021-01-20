using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstract
{
   public interface IContactRepository
    {
        Task<List<Contact>> GetContacts();
        Task<Contact> GetContact(int id);
        Task AddContact(Contact contact);
        Task RemoveContact(int id);
        Task<bool> SaveChangesAsync();
    }
}
