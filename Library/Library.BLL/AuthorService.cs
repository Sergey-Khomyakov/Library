using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with author
    /// </summary>
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        /// <summary>
        /// Add new author
        /// </summary>
        public async Task AddNewAuthorAsync(Author author)
        {
            await _authorRepository.AddNewAuthorAsync(author);
        }

        /// <summary>
        /// Returns the author by id 
        /// </summary>
        public async Task<IEnumerable<Author>> GetAuthorsAsync(int authorId)
        {
            return await _authorRepository.GetAuthorsAsync(authorId);
        }

        /// <summary>
        /// Removes author by id.
        /// </summary>
        public async Task RemoveAuthorAsync(int authorId)
        {
            await _authorRepository.RemoveAuthorAsync(authorId);
        }
    }
}
