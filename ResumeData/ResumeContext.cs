using Microsoft.EntityFrameworkCore;
using ResumeData.Models;

namespace ResumeData
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
