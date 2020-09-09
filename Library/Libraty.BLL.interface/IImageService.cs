using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with images
    /// </summary>
    public interface IImageService
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
