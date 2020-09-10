using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with genre
    /// </summary>
    public interface IGenreRepository
    {
        /// <summary>
        /// Returns a list of genre.
        /// </summary>
        IEnumerable<string> GetGenre();
    }
}
