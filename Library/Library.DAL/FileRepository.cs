using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with file
    /// </summary>
    public class FileRepository : IFileRepository
    {
        /// <summary>
        /// Add new file
        /// </summary>
        public Task AddNewFileAsync(File file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the file
        /// </summary>
        public Task<IEnumerable<File>> GetFileAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes file by id.
        /// </summary>
        public Task RemoveFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}
