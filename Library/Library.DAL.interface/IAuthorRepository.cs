using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with author
    /// </summary>
    public interface IAuthorRepository
    {
        /// <summary>
        /// Add new author
        /// </summary>
        Task AddNewAuthorAsync(Author author);

        /// <summary>
        /// Returns the author by id 
        /// </summary>
        Task<IEnumerable<Author>> GetAuthorsAsync(int authorId);

        /// <summary>
        /// Removes author by id.
        /// </summary>
        Task RemoveAuthorAsync(int authorId);
    }
}
