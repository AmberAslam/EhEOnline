using EhEOnline.Shared;
using Microsoft.EntityFrameworkCore;

namespace EhEOnline.Server.Data
{
    public class mydatabase : DbContext
    {
        public mydatabase(DbContextOptions<mydatabase> options) : base()
        {
        }

        public DbSet<ContactUs> ContactUs { get; set; }
    }
}
