using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with genre
    /// </summary>
    public interface IGenreService
    {
        /// <summary>
        /// Returns a list of genre.
        /// </summary>
        IEnumerable<string> GetGenre();
    }
}
