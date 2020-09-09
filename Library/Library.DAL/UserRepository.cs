using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Interface;
using Library.Common;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with users
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Add new user
        /// </summary>
        public Task AddNewUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the user by id 
        /// </summary>
        public Task<IEnumerable<User>> GetUsersAsync(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes user by id.
        /// </summary>
        public Task RemoveUserAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
