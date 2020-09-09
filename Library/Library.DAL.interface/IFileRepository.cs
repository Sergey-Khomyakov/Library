using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with file
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Add new file
        /// </summary>
        Task AddNewFileAsync(File file);

        /// <summary>
        /// Returns the file
        /// </summary>
        Task<IEnumerable<File>> GetFileAsync();

        /// <summary>
        /// Removes file by id.
        /// </summary>
        Task RemoveFileAsync(int fileId);
    }
}
