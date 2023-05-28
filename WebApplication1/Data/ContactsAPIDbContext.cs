using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ContactsAPIDbContext : Microsoft.EntityFrameworkCore.DbContext
    { 
        public ContactsAPIDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
