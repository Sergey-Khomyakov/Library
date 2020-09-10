using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with users
    /// </summary>
    public interface IUserRepository
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
