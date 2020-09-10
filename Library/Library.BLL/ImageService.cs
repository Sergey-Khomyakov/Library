using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.Common;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with images
    /// </summary>
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        /// <summary>
        /// Add new Image
        /// </summary>
        public async Task AddNewImageAsync(Image image)
        {
            await _imageRepository.AddNewImageAsync(image);
        }

        /// <summary>
        /// Returns the image
        /// </summary>
        public async Task<IEnumerable<Image>> GetImageAsync()
        {
            return await _imageRepository.GetImageAsync();
        }

        /// <summary>
        /// Removes image by id.
        /// </summary>
        public async Task RemoveImageAsync(int imageId)
        {
            await _imageRepository.RemoveImageAsync(imageId);
        }
    }
}
