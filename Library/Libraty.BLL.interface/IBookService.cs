using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with book
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Add new book
        /// </summary>
        Task AddNewBookAsync(Book book);

        /// <summary>
        /// Returns the book by id 
        /// </summary>
        Task<IEnumerable<Book>> GetBookAsync(int bookId);

        /// <summary>
        /// Removes book by id.
        /// </summary>
        Task RemoveBookAsync(int bookId);
    }
}
