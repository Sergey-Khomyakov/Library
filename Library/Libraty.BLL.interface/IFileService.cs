using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with file
    /// </summary>
    public interface IFileService
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
