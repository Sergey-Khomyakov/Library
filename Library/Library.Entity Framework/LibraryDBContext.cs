using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Library.Entity_Framework
{
    class LibraryDBContext : DbContext
    {
        public LibraryDBContext() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorsBook> AuthorsBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<GenresBook> GenresBooks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ImagesBook> ImagesBooks { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<FilesBook> FilesBooks { get; set; }
        public DbSet<File> Files { get; set; }

    }
}
