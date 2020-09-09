using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with image
    /// </summary>
    public interface IImageRepository
    {
        /// <summary>
        /// Add new Image
        /// </summary>
        Task AddNewImageAsync(Image image);

        /// <summary>
        /// Returns the image
        /// </summary>
        Task<IEnumerable<Image>> GetImageAsync();

        /// <summary>
        /// Removes image by id.
        /// </summary>
        Task RemoveImageAsync(int imageId);
    }
}
