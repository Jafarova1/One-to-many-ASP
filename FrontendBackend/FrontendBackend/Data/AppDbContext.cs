using FrontendBackend.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace FrontendBackend.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ProjectDetail> Deatils { get; set; }

        public DbSet<ProjectImage> ProjectImages { get; set; }



    }
}
