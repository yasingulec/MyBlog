using Blog.Data.Repositories.Abstract;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concrete
{
    public class ContactRepository : IContactRepository
    {
        private AppDbContext _ctx;
        public ContactRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task AddContact(Contact contact)
        {
           await _ctx.Contacts.AddAsync(contact);
        }

        public async Task<Contact> GetContact(int id)
        {
            var contact = await _ctx.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            return contact;
        }

        public async Task<List<Contact>> GetContacts()
        {
            var contacts = await _ctx.Contacts.ToListAsync();
            return contacts;
        }

        public async Task RemoveContact(int id)
        {
            var contact = await GetContact(id);
            _ctx.Contacts.Remove(contact);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
