using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with book
    /// </summary>
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        /// <summary>
        /// Add new book
        /// </summary>
        public async Task AddNewBookAsync(Book book)
        {
            await _bookRepository.AddNewBookAsync(book);
        }

        /// <summary>
        /// Returns the book by id 
        /// </summary>
        public async Task<IEnumerable<Book>> GetBookAsync(int bookId)
        {
            return await _bookRepository.GetBookAsync(bookId);
        }

        /// <summary>
        /// Removes book by id.
        /// </summary>
        public async Task RemoveBookAsync(int bookId)
        {
            await _bookRepository.RemoveBookAsync(bookId);
        }
    }
}
