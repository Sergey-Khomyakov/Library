using System;
using Library.BLL;
using Library.BLL.Interface;
using Library.DAL;
using Library.DAL.Interface;
using Ninject.Modules;

namespace Library.ContainerBuilder
{
    /// <summary>
    /// Ioc-container.
    /// </summary>
    public class ContainerBuilder : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IRolesService>().To<RolesService>();
            Bind<IImageService>().To<ImageService>();
            Bind<IGenreService>().To<GenreService>();
            Bind<IFileService>().To<FileService>();
            Bind<IBookService>().To<BookService>();
            Bind<IAuthorService>().To<AuthorService>();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IRolesRepository>().To<RolesRepository>();
            Bind<IImageRepository>().To<IImageRepository>();
            Bind<IGenreRepository>().To<GenreRepository>();
            Bind<IFileRepository>().To<FileRepository>();
            Bind<IBookRepository>().To<BookRepository>();
            Bind<IAuthorRepository>().To<AuthorRepository>();
        }
    }
}
