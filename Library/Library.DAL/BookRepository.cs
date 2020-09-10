using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with book
    /// </summary>
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Add new book
        /// </summary>
        public Task AddNewBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the book by id 
        /// </summary>
        public Task<IEnumerable<Book>> GetBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes book by id.
        /// </summary>
        public Task RemoveBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
