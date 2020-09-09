using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.BLL.Interface
{
    /// <summary>
    /// Service for working with users
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Add new user
        /// </summary>
        Task AddNewUserAsync(User user);

        /// <summary>
        /// Returns the user by id 
        /// </summary>
        Task<IEnumerable<User>> GetUsersAsync(int userId);

        /// <summary>
        /// Removes user by id.
        /// </summary>
        Task RemoveUserAsync(int userId);
    }
}
