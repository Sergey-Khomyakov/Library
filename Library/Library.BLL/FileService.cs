using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with file
    /// </summary>
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        /// <summary>
        /// Add new file
        /// </summary>
        public async Task AddNewFileAsync(File file)
        {
            await _fileRepository.AddNewFileAsync(file);
        }

        /// <summary>
        /// Returns the file
        /// </summary>
        public async Task<IEnumerable<File>> GetFileAsync()
        {
            return await _fileRepository.GetFileAsync();
        }

        /// <summary>
        /// Removes file by id.
        /// </summary>
        public async Task RemoveFileAsync(int fileId)
        {
            await _fileRepository.RemoveFileAsync(fileId);
        }
    }
}
