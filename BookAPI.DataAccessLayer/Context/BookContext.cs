using BookAPI.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.DataAccessLayer.Context
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseSqlServer("Server=DESKTOP-S74UGVJ;initial catalog=BookAPI;integrated security=true; TrustServerCertificate=true");
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            // Book - Writer ilişkisi

            modelBuilder.Entity<Book>()

                .HasOne(b => b.Writer)

                .WithMany(w => w.Books)

                .HasForeignKey(b => b.WriterID);



            // Book - Category ilişkisi

            modelBuilder.Entity<Book>()

                .HasOne(b => b.Category)

                .WithMany(c => c.Books)

                .HasForeignKey(b => b.CategoryID);



            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
} 