using DotNetCore_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}