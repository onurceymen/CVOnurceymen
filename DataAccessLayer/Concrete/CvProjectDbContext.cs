using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class CvProjectDbContext : DbContext
    {
    
        public CvProjectDbContext(DbContextOptions<CvProjectDbContext> options) : base(options)
        {
        }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=MyCvSystem; User Id=SA;Password=reallyStrongPwd123;Encrypt=true;TrustServerCertificate=True;");
        }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Bookcase> Bookcases { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
