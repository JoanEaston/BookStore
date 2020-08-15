using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions<BookContext> Options): base(Options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.Authors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BooksAuthored)
                .HasForeignKey(ba => ba.AuthorId);
          //  modelBuilder.Entity<Book>().HasMany(b => b.Authors).WithOne
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<AdminType> AdminTypes { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }

    }
}
