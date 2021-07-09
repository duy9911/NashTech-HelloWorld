using Microsoft.EntityFrameworkCore;

namespace Practice7.Models
{
    public class LibraryContext :DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(c=>c.BookId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Book>().HasMany(c=>c.Authors);
            modelBuilder.Entity<Author>().Property(c=>c.AuthorId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Author>().HasMany(c=>c.Books);
            modelBuilder.Entity<Client>().Property(c=>c.ClientId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Client>().HasMany(c=>c.Books);

            modelBuilder.Entity<Client>().HasData(new Client
            {
                ClientId = 1,
                ClientName = "Category1",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = 1,
                AuthorName = "Author A",
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                BookName = "Book1",
                ClientId=1
            });
        }

        public DbSet<Author> Authors {get;set;}

        public DbSet<Client> Clients {get;set;}

        public DbSet<Book> Books {get;set;}

    }
}