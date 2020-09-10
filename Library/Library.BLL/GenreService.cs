using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with genre
    /// </summary>
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        /// <summary>
        /// Returns a list of genre.
        /// </summary>
        public IEnumerable<string> GetGenre()
        {
            return _genreRepository.GetGenre();
        }
    }
}
