using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with genre
    /// </summary>
    public class GenreRepository : IGenreRepository
    {
        /// <summary>
        /// Returns a list of genre.
        /// </summary>
        public IEnumerable<string> GetGenre()
        {
            throw new NotImplementedException();
        }
    }
}
