using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with image
    /// </summary>
    public class ImageRepository : IImageRepository
    {
        /// <summary>
        /// Add new Image
        /// </summary>
        public Task AddNewImageAsync(Image image)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the image
        /// </summary>
        public Task<IEnumerable<Image>> GetImageAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes image by id.
        /// </summary>
        public Task RemoveImageAsync(int imageId)
        {
            throw new NotImplementedException();
        }
    }
}
