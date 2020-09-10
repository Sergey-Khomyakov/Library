using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with author
    /// </summary>
    public interface IAuthorService
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
