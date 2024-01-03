using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext() { }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options) { }

        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contect> Contects { get; set; }
        public DbSet<ContectMessage> ContectMessages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }  
        public DbSet<Author>Authors { get; set; }
        public DbSet<Favorite>favortites { get; set; }
        public DbSet<User>Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
            "Server=DESKTOP-FLT1JUM;Database=Kutuphane;" +
            "TrustServerCertificate=True;Trusted_Connection=True;Encrypt=False"
               );
            }

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorite>()
                .HasKey(x => new { x.BookId, x.UserId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
