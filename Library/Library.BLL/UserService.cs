using System;
using Library.BLL.Interface;
using Library.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with users
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Add new user
        /// </summary>
        public async Task AddNewUserAsync(User user)
        {
            await _userRepository.AddNewUserAsync(user);
        }

        /// <summary>
        /// Returns the user by id 
        /// </summary>
        public async Task<IEnumerable<User>> GetUsersAsync(int userId)
        {
            return await _userRepository.GetUsersAsync(userId);
        }

        /// <summary>
        /// Removes user by id.
        /// </summary>
        public async Task RemoveUserAsync(int userId)
        {
            await _userRepository.RemoveUserAsync(userId);
        }
    }
}
