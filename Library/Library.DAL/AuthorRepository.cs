using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with author
    /// </summary>
    public class AuthorRepository : IAuthorRepository
    {
        /// <summary>
        /// Add new author
        /// </summary>
        public Task AddNewAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the author by id 
        /// </summary>
        public Task<IEnumerable<Author>> GetAuthorsAsync(int authorId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes author by id.
        /// </summary>
        public Task RemoveAuthorAsync(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
