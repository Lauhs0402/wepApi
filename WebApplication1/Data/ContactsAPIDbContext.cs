using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1.Data
{
    public class ContactsAPIDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }

    }
   }
